// const bcrypt = require('bcryptjs');

class User {
  constructor(username, email, passwordHash) {
    this.username = username;
    this.email = email;
    this.passwordHash = passwordHash;
  }

  static validade(body) {
    const errors = [];

    if (!body.username) errors.push('username can not be empty');
    if (!body.email) errors.push('email can not be empty');
    if (!body.passwordHash) errors.push('password can not be empty');

    // Precisa testar essa parte de hash

    // if (body.passwordHash) {
    //   User.passwordHash = await bcrypt.hash(User.password, 8);
    // }

    // // eslint-disable-next-line func-names
    // User.prototype.checkPassword = function (password) {
    //   return bcrypt.compare(password, this.passwordHash);
    // };

    return errors;
  }
}

module.exports = User;
