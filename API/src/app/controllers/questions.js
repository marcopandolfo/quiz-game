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
        const question = {
            question: req.body.question,
            correct_answer: req.body.correct_answer,
            category: req.body.category,
            incorrect_answers: req.body.incorrect_answers,
        };

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
        getQuestionsDao().deleteQuestion(req.params.id, (err) => {
            if (err) return res.status(500).json(err);
            return res.status(204).send();
        });
    });
};
