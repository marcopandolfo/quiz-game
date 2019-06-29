class User {
  constructor(username, email, password, confirmPassword) {
    this.username = username;
    this.email = email;
    this.password = password;
    this.confirmPassword = confirmPassword;
  }

  static validade(body) {
    const errors = [];

    if (!body.username) errors.push("username can not be empty");
    if (!body.email) errors.push("email can not be empty");
    if (!body.password) errors.push("password can not be empty");
    if (!body.confirmPassword) errors.push("confirmPassword can not be empty");

    return errors;
  }
}

module.exports = User;
