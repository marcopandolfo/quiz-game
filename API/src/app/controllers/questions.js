/* eslint-disable consistent-return */
const Question = require('../models/question');

module.exports = (app) => {
    const getQuestionsDao = () => {
        const connection = app.infra.connectionFactory();
        return new app.infra.QuestionsDao(connection);
    };

    // GET
    app.get('/questions', (req, res) => {
        getQuestionsDao().getRandom((err, result) => {
            if (err) return res.status(500).json(err);
            return res.status(200).json(result);
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
            return res.status(200).json({ question, info });
        });
    });

    // DELETE
    app.delete('/questions/:id', (req, res) => {
        // eslint-disable-next-line no-restricted-globals
        if (isNaN(req.params.id)) return res.status(400).send({ errors: ['invalid ID'] });

        getQuestionsDao().deleteQuestion(req.params.id, (err) => {
            if (err) return res.status(500).json(err);
            return res.status(204).send();
        });
    });
};
