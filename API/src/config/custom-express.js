const express = require("express");
const consign = require("consign");
const bodyParser = require("body-parser");
const morgan = require("morgan");
const logger = require("./logger");

// App
const app = express();

// BodyParser
app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

// Consign
consign({ cwd: "src\\app" })
  .include("infra")
  .then("controllers")
  .into(app);

// Morgan
app.use(
  morgan("common", {
    stream: {
      write: mensagem => {
        logger.info(mensagem);
      }
    }
  })
);

module.exports = app;
