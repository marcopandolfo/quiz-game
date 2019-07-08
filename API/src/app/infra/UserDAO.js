/* eslint-disable no-underscore-dangle */
function UserDAO(connection) {
  this._connection = connection;
}

UserDAO.prototype.saveUser = function saveUser(users, callbak) {
  this._connection.query('INSERT INTO users SET ?', users, callbak);
};

UserDAO.prototype.deleteUser = function deleteUser(id, callbak) {
  this._connection.query('DELETE FROM users WHERE ID = ?', [id], callbak);
};

UserDAO.prototype.getUser = function getUser(user, callbak) {
  this._connection.query('SELECT * FROM users WHERE email=? AND password=?', [user.email, user.password], callbak);
};

// eslint-disable-next-line func-names
module.exports = function () {
  return UserDAO;
};
