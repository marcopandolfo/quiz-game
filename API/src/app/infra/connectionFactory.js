/* eslint-disable func-names */
const mysql = require('mysql');

function createDBConnection() {
  return mysql.createConnection({
    multipleStatements: true,
    host: 'localhost',
    user: 'root',
    password: 'password', // insert you password
    database: 'quiz',
  });
}

module.exports = function () {
  return createDBConnection;
};
