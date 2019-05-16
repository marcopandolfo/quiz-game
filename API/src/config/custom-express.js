const express = require('express');
const consign = require('consign');
const bodyParser = require('body-parser');

// App
const app = express();

// BodyParser
app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

// Consign
consign({ cwd: 'src\\app' })
    .include('infra')
    .then('controllers')
    .into(app);

module.exports = app;
