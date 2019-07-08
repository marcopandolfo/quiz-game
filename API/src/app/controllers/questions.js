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
    getQuestionsDao().getRandom((err, result) => {
      if (err) {
        logger.error(err);

        return res.status(500).send(err);
      }

      return res.status(200).json(result[0]);
    });
  });

  // GET (category)
  // 400 Se a categoria for invalida
  // 204 Se nao tiver questions naquela categoria
  app.get('/questions/:category', (req, res) => {
    const category = req.params.category.toString();

    if (!categories().includes(category)) {
      return res.status(400).json({ errors: ['invalid category'] });
    }

    getQuestionsDao().getQuestion(category, (err, result) => {
      if (err) {
        logger.error(err);
        return res.status(500).send(err);
      }

      if (!result.length) return res.status(204).send();

      return res.status(200).json(result[0]);
    });
  });

  // POST
  app.post('/questions', (req, res) => {
    // Validate
    const errors = Question.validate(req.body);
    if (errors.length !== 0) return res.status(400).send({ errors });

    const question = new Question(
      req.body.question,
      req.body.correct_answer,
      req.body.category,
      req.body.incorrect_answers,
    );

    // Save to DB
    getQuestionsDao().saveQuestion(question, (err, result) => {
      if (err) {
        logger.error(err);
        return res.status(500).send(err);
      }

      const info = {
        status: 'CREATED',
        insertId: result.insertId,
      };
      logger.info('[QUESTION CREATED]', {
        id: result.insertId.toString(),
        date: new Date().toDateString(),
      });

      return res.status(201).json({ question, info });
    });
  });

  // DELETE
  app.delete('/questions/:id', (req, res) => {
    const questionID = req.params.id;

    // eslint-disable-next-line no-restricted-globals
    if (isNaN(questionID)) { return res.status(400).send({ errors: ['invalid ID'] }); }

    getQuestionsDao().deleteQuestion(questionID, (err) => {
      if (err) {
        logger.error(err);
        return res.status(500).send(err);
      }

      logger.info('[QUESTION DELETED]', {
        id: questionID,
        date: new Date().toDateString(),
      });

      return res.status(204).send();
    });
  });
};
