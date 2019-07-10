/* eslint-disable no-underscore-dangle */
function UserDAO(connection) {
  this._connection = connection;
}

// Salvar um user
UserDAO.prototype.saveUser = function saveUser() {
  return new Promise((resolve, reject) => {
    this._connection.query('INSERT INTO users SET ?', (err, result) => {
      if (err) return reject(err);

      return resolve(result);
    });
  });
};

// Pegar algum user
UserDAO.prototype.getUser = function getUser() {
  return new Promise((resolve, reject) => {
    this._connection.query('SELECT * FROM users WHERE email=? AND password=?', (err, result) => {
      if (err) return reject(err);

      return resolve(result);
    });
  });
};

// Deletar um user
UserDAO.prototype.deleteUser = function deleteUser() {
  return new Promise((resolve, reject) => {
    this._connection.query('DELETE FROM users WHERE ID = ?', (err, result) => {
      if (err) return reject(err);

      return resolve(result);
    });
  });
};

// eslint-disable-next-line func-names
module.exports = function () {
  return UserDAO;
};
