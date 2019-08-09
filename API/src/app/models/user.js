const bcrypt = require("bcryptjs");

class User {
  constructor(username, email, password, passwordHash) {
    this.username = username;
    this.email = email;
    this.password = password;
    this.passwordHash = passwordHash;
  }

  static async validade(body) {
    const errors = [];

    if (!body.username) errors.push("username can not be empty");
    if (!body.email) errors.push("email can not be empty");
    if (!body.password) errors.push("password can not be empty");

    // Precisa testar essa parte de hash

    if (body.password) {
      User.passwordHash = await bcrypt.hash(User.password, 8);
    }

    User.prototype.checkPassword = function(password) {
      return bcrypt.compare(password, this.passwordHash);
    };

    return errors;
  }
}

module.exports = User;
