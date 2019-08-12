/* eslint-disable no-underscore-dangle */
function UserDAO(connection) {
  this._connection = connection;
}

// Salvar um user
UserDAO.prototype.saveUser = function saveUser(user) {
  return new Promise((resolve, reject) => {
    this._connection.query('INSERT INTO users SET ?', user, (err, result) => {
      if (err) return reject(err);

      return resolve(result);
    });
  });
};


// Get hash
UserDAO.prototype.getHashFromDB = function getHashFromDB(email) {
  return new Promise((resolve, reject) => {
    this._connection.query('SELECT passwordHash FROM users WHERE email=?', [email],
      (err, result) => {
        if (err) return reject(err);

        if (result[0]) return resolve(result[0].passwordHash);

        return resolve('notfound');
      });
  });
};

// Pegar algum user
UserDAO.prototype.getUser = function getUser(email) {
  return new Promise((resolve, reject) => {
    this._connection.query('SELECT * FROM users WHERE email=?', [email],
      (err, result) => {
        if (err) return reject(err);

        return resolve(result[0]);
      });
  });
};

// Deletar um user
UserDAO.prototype.deleteUser = function deleteUser(id) {
  return new Promise((resolve, reject) => {
    this._connection.query('DELETE FROM users WHERE ID = ?', [id], (err, result) => {
      if (err) return reject(err);

      return resolve(result);
    });
  });
};

// eslint-disable-next-line func-names
module.exports = function () {
  return UserDAO;
};
