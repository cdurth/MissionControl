var express = require('express');
var app = express();

app.get('/launch', function (req, res) {
  var tube = req.query.tube;
  console.log('launch request received for: '+ tube);
  res.send('launched '+ tube);
});

app.listen(9999, function () {
  console.log('Test server listening on port 9999!');
});