/* eslint-disable new-cap */
const winston = require('winston');
const fs = require('fs');

if (!fs.existsSync('./src/app/logs')) {
  fs.mkdirSync('logs');
}

module.exports = new winston.createLogger({
  transports: [
    new winston.transports.File({
      level: 'info',
      filename: './src/app/logs/api.log',
      maxsize: 100000,
      maxFiles: 10,
    }),

    new winston.transports.File({
      level: 'error',
      filename: './src/app/logs/error.log',
      maxsize: 100000,
      maxFiles: 10,
    }),
  ],
});
