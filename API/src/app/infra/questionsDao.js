/* eslint-disable no-underscore-dangle */
function QuestionsDao(connection) {
    this._connection = connection;
}

QuestionsDao.prototype.saveQuestion = function saveQuestion(question, callback) {
    this._connection.query('INSERT INTO questions SET ?', question, callback);
};

QuestionsDao.prototype.getAll = function getAll(callback) {
    this._connection.query('SELECT * FROM questions', callback);
};

QuestionsDao.prototype.getRandom = function getRandom(callback) {
    this._connection.query('SELECT * FROM questions ORDER BY RAND() LIMIT 1', callback);
};

QuestionsDao.prototype.deleteQuestion = function deleteQuestion(id, callback) {
    this._connection.query('DELETE * FROM questions WHERE ID= ?', id, callback);
};

// eslint-disable-next-line func-names
module.exports = function () {
    return QuestionsDao;
};
