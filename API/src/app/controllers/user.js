/* eslint-disable consistent-return */
const User = require('../models/user');
const logger = require('../../config/logger');

module.exports = (app) => {
  const getUsersDao = () => {
    const connection = app.infra.connectionFactory();
    return new app.infra.UserDAO(connection);
  };

  // POST
  app.post('/users', (req, res) => {
    // Validate
    const errors = User.validade(req.body);
    if (errors.length !== 0) return res.status(400).send({ errors });

    const user = new User(req.body.username, req.body.email, req.body.password);

    // Save to DB
    getUsersDao().saveUser(user, (err, result) => {
      if (err) {
        logger.error(err);
        return res.status(500).send(err);
      }

      const info = {
        status: 'CREATED',
        insertId: result.insertId,
      };
      logger.info('[USER CREATED]', {
        id: result.insertId.toString(),
        date: new Date().toDateString(),
        username: user.username,
      });
      return res.status(201).json({ user, info });
    });
  });

  // DELETE
  app.delete('/users/:id', (req, res) => {
    // eslint-disable-next-line no-restricted-globals
    if (isNaN(req.params.id)) {
      return res.status(400).send({ errors: ['invalid ID'] });
    }

    getUsersDao().deleteUser(req.params.id, (err) => {
      if (err) {
        logger.error(err);
        return res.status(500).send(err);
      }

      logger.info('[USER DELETED]', {
        id: req.params.id.toString(),
        date: new Date().toDateString(),
      });

      return res.status(204).send();
    });
  });

  // GET
  // idk if 204 code is appropriate for this case
  app.get('/users', (req, res) => {
    const user = {
      email: req.body.email,
      password: req.body.password,
    };

    getUsersDao().getUser(user, (err, result) => {
      if (err) {
        logger.error(err);
        return res.status(500).json(err);
      }

      if (!result.length) {
        return res.status(204).send();
      }

      return res.status(200).json(result[0]);
    });
  });
};
