const sqlite3 = require('sqlite3').verbose();

const bd = new sqlite3.Database('data.db');

// TODO: CREATE SERIALIZATION

process.on('SIGINT', () => {
    bd.close(() => {
        console.log('DB closed!');
        process.exit(0);
    });
});
