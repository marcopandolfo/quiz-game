function UserDAO(connection) {
  this._connection = connection;
}

UserDAO.prototype.saveUser = function saveUser(users, callbak) {
  this._connection.query("INSERT INTO users SET ?", users, callbak);
};

UserDAO.prototype.deleteUser = function deleteUser(id, callbak) {
  this._connection.query("DELETE FROM users WHERE ID = ?", [id], callbak);
};

module.exports = function() {
  return UserDAO;
};
