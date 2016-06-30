var express = require('express');
var app = express();

app.get('/launch', function (req, res) {
  var tube = req.query.tube;
  var date = new Date(Date.now());
  console.log('launch request received for: '+ tube + ' at '+ date);
  res.send('launched '+ tube);
});

app.listen(9999, function () {
  console.log('Test server listening on port 9999!');
});