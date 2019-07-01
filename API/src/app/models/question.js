/* eslint-disable class-methods-use-this */
/* eslint-disable camelcase */
class Question {
  constructor(question, correct_answer, category, incorrect_answers) {
    this.question = question;
    this.correct_answer = correct_answer;
    this.category = category;
    this.incorrect_answers = incorrect_answers;
  }

  static validate(body) {
    const errors = [];

    if (!body.question) errors.push('question can not be empty');
    if (!body.correct_answer) errors.push('correct_answer can not be empty');
    if (!body.category) errors.push('category can not be empty');
    if (!body.incorrect_answers || !body.incorrect_answers.includes('/')) errors.push('incorrect_answers is invalid');

    return errors;
  }
}

module.exports = Question;
