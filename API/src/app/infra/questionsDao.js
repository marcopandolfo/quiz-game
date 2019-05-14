/* eslint-disable class-methods-use-this */
/* eslint-disable no-underscore-dangle */
class QuestionsDao {
    constructor(db) {
        this._db = db;
    }

    get() {
        return new Promise((resolve, reject) => {
            this._db.get('SELECT * FROM questions ORDER BY RANDOM() LIMIT 1',
                (err, result) => {
                    if (err) {
                        return reject(JSON.stringify(err));
                    }
                    return resolve(result);
                });
        });
    }
}

module.exports = QuestionsDao;
