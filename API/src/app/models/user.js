// const bcrypt = require("bcryptjs");

class User {
  constructor(username, email, password) {
    this.username = username;
    this.email = email;
    this.password = password;
  }

  static validade(body) {
    const errors = [];

    if (!body.username) errors.push("username can not be empty");
    if (!body.email) errors.push("email can not be empty");
    if (!body.password) errors.push("password can not be empty");

    return errors;
  }
  /* , {
        hooks: {
            beforeSave: async user => {
                if (user.password) {
                    user.password = await bcrypt.hash(user.password, 8)
                }
            }
        }
    }
  */
}

module.exports = User;
