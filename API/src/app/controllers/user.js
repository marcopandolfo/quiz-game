/* eslint-disable consistent-return */
const User = require('../models/user');

module.exports = (app) => {
  const getUsers = () => {
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
    getUsers().saveUser(user, (err, result) => {
      if (err) return res.status(500).json(err);

      const info = {
        status: 'CREATED',
        insertId: result.insertId,
      };

      return res.status(201).json({ user, info });
    });
  });

  // DELETE
  app.delete('/users/:id', (req, res) => {
    // eslint-disable-next-line no-restricted-globals
    if (isNaN(req.params.id)) return res.status(400).send({ errors: ['invalid ID'] });

    getUsers().deleteUser(req.params.id, (err) => {
      if (err) return res.status(500).json(err);
      return res.status(204).send();
    });
  });
};
