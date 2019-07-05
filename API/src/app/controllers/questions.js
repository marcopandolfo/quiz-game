/* eslint-disable consistent-return */
const Question = require('../models/question');
const logger = require('../../config/logger');

module.exports = (app) => {
  const getQuestionsDao = () => {
    const connection = app.infra.connectionFactory();
    return new app.infra.QuestionsDAO(connection);
  };

  // GET
  app.get('/questions', (req, res) => {
    getQuestionsDao().getRandom((err, result) => {
      if (err) return res.status(500).json(err);
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
      if (err) return res.status(500).json(err);

      const info = {
        status: 'CREATED',
        insertId: result.insertId,
      };
      logger.info('[QUESTION CREATED]', { id: result.insertId.toString(), date: new Date().toDateString() });

      return res.status(201).json({ question, info });
    });
  });

  // DELETE
  app.delete('/questions/:id', (req, res) => {
    const questionID = req.params.id;

    // eslint-disable-next-line no-restricted-globals
    if (isNaN(questionID)) return res.status(400).send({ errors: ['invalid ID'] });

    getQuestionsDao().deleteQuestion(questionID, (err) => {
      if (err) return res.status(500).json(err);
      logger.info('[QUESTION DELETED]', { id: questionID, date: new Date().toDateString() });

      return res.status(204).send();
    });
  });
};
