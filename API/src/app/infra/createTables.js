const logger = require('../../config/logger');

const createTables = (connection) => {
  connection.query(`
  CREATE TABLE IF NOT EXISTS users (
    id int(10) NOT NULL auto_increment,
    username varchar(255) NOT NULL,
    email varchar(255) NOT NULL,
    passwordHash varchar(255) NOT NULL,
    PRIMARY KEY( id )
  );

  CREATE TABLE IF NOT EXISTS questions (
    id int(10) NOT NULL auto_increment,
    question varchar(255) NOT NULL,
    correct_answer varchar(255) NOT NULL,
    incorrect_answers varchar(255) NOT NULL,
    category varchar(255) NOT NULL,
    PRIMARY KEY( id )
  );
  `, (err) => {
    if (err) {
      logger.error(err);
      throw err;
    }
    console.log('Auto-create mysql tables sucess');
  });
};

module.exports = () => createTables;
