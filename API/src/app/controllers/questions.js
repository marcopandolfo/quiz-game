module.exports = (app) => {
    const getQuestionsDao = () => {
        const connection = app.infra.connectionFactory();
        return new app.infra.QuestionsDao(connection);
    };

    app.get('/questions', (req, res) => {
        getQuestionsDao().getRandom((err, result) => {
            if (err) return res.status(500).json(err);
            return res.status(200).json(result);
        });
    });

    app.post('/questions', (req, res) => {
        getQuestionsDao().saveQuestion(req.body, (err, result) => {
            if (err) return res.status(500).json(err);
            return res.status(200).json(result);
        });
    });
};
