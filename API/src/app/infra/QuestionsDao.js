/* eslint-disable no-underscore-dangle */
function QuestionsDao(connection) {
  this._connection = connection;
}

// Salvar uma questão
QuestionsDao.prototype.saveQuestion = function saveQuestion(question) {
  return new Promise((resolve, reject) => {
    this._connection.query('INSERT INTO questions SET ?', question, (err, result) => {
      if (err) return reject(err);

      return resolve(result);
    });
  });
};

// Pegar todas as questões
QuestionsDao.prototype.getAll = function getAll() {
  return new Promise((resolve, reject) => {
    this._connection.query('SELECT * FROM questions', (err, result) => {
      if (err) return reject(err);

      return resolve(result);
    });
  });
};

// Pegar uma questão randomicamente
QuestionsDao.prototype.getRandom = function getRandom() {
  return new Promise((resolve, reject) => {
    this._connection.query('SELECT * FROM questions ORDER BY RAND() LIMIT 1', (err, result) => {
      if (err) return reject(err);

      return resolve(result);
    });
  });
};

// Pegar questões de uma categoria especifica
QuestionsDao.prototype.getQuestion = function getQuestion(category) {
  return new Promise((resolve, reject) => {
    this._connection.query(
      'SELECT * FROM questions WHERE category = ? ORDER BY RAND() LIMIT 1', category,
      (err, result) => {
        if (err) return reject(err);

        return resolve(result);
      },
    );
  });
};

// Deletar uma questão
QuestionsDao.prototype.deleteQuestion = function deleteQuestion(id) {
  return new Promise((resolve, reject) => {
    this._connection.query('DELETE FROM questions WHERE ID = ?', id, (err, result) => {
      if (err) return reject(err);

      return resolve(result);
    });
  });
};

// eslint-disable-next-line func-names
module.exports = function () {
  return QuestionsDao;
};
