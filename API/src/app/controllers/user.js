const User = require("../models/user");

module.exports = app => {
  // POST
  app.post("/users", (req, res) => {
    // Validate
    const errors = User.validade(req.body);
    if (errors.length !== 0) return res.status(400).send({ errors });

    const user = new User(
      req.body.username,
      req.body.email,
      req.body.password,
      req.body.confirmPassword
    );

    // Save to DB
  });

  // DELETE
  app.delete("/users/:id", (req, res) => {
    if (isNaN(req.params.id))
      return res.status(400).send({ errors: ["invalid ID"] });
  });
};
