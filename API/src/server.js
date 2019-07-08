const app = require('./config/custom-express');

// Auto create mysql tables
const connection = app.infra.connectionFactory();
app.infra.createTables(connection);

app.listen(3000, () => {
  console.log('Servidor rodando na porta 3000');
});
