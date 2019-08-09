/* eslint-disable consistent-return */
const Question = require('../models/question');
const logger = require('../../config/logger');
const categories = require('../models/categories');

module.exports = (app) => {
  const getQuestionsDao = () => {
    const connection = app.infra.connectionFactory();
    return new app.infra.QuestionsDAO(connection);
  };

  // GET
  app.get('/questions', (req, res) => {
    getQuestionsDao().getRandom()
      .then(result => res.status(200).json(result[0]).send())
      .catch((err) => {
        logger.error(err.toString());
        return res.status(500).json(err.toString());
      });
  });

  // GET (category)
  // 400 If category is invalid
  // 204 If there are no questions from that category
  app.get('/questions/:category', (req, res) => {
    const category = req.params.category.toString();

    if (!categories().includes(category)) {
      return res.status(400).json({ errors: ['invalid category'] });
    }

    getQuestionsDao()
      .getQuestion(category)
      .then((result) => {
        if (!result.length) return res.status(204).send();

        return res.status(200).json(result[0]);
      })
      .catch((err) => {
        logger.error(err.toString());
        return res.status(500).json(err.toString());
      });
  });

  // POST
  app.post('/questions', (req, res) => {
    // Validate
    const errors = Question.validate(req.body);
    if (errors.length !== 0) return res.status(400).json({ errors });

    // Question
    const question = new Question(
      req.body.question,
      req.body.correct_answer,
      req.body.category,
      req.body.incorrect_answers,
    );

    getQuestionsDao().saveQuestion(question)
      .then((result) => {
        const info = {
          status: 'CREATED',
          insertId: result.insertId,
        };

        logger.info('[QUESTION CREATED]', {
          id: result.insertId.toString(),
          date: new Date().toDateString(),
        });

        return res.status(201).json({ question, info });
      })
      .catch((err) => {
        logger.error(err.toString());
        return res.status(500).json(err.toString());
      });
  });

  // DELETE
  app.delete('/questions/:id', (req, res) => {
    const questionID = req.params.id;

    // eslint-disable-next-line no-restricted-globals
    if (isNaN(questionID)) {
      return res.status(400).send({ errors: ['invalid ID'] });
    }

    getQuestionsDao()
      .deleteQuestion(questionID)
      .then(() => {
        logger.info('[QUESTION DELETED]', {
          id: questionID,
          date: new Date().toDateString(),
        });

        return res.status(204).send();
      })
      .catch((err) => {
        logger.error(err.toString());
        return res.status(500).json(err.toString());
      });
  });
};
