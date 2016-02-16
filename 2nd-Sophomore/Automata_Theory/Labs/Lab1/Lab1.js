// WARNING! Run "npm i prompt" (without quotes) in the terminal before start
var prompt = require('prompt');

prompt.start();

// Reading input string
prompt.get(['input'], function(err, result) {
  if (err) { return onErr(err); }
  if (!checkInput(result.input)) {
    var matrix = new Array(5);
    initMatrix(matrix); 
    DFA(result.input, matrix);    
  } else 
    console.log('Wrong input');    
});

function onErr(err) {
  console.log(err);
  return 1;
}

function checkInput(text) {
  for (var i = 0; i < text.length; i++)
    if (text[i] !== 'a' && text[i] !== 'b')
      return 1;
  return 0;
};

function initMatrix(matrix) {
  for (var i = 0; i < matrix.length; i++)
    matrix[i] = new Array(2);

  for (var i = 0; i < matrix.length; i++)
    for (var j = 0; j < matrix[i].length; j++)
      if (i !== 4) 
        matrix[i][j] = i + 1;
      else
        matrix[i][j] = 0;

// Matrix show
//  for (var i = 0; i < matrix.length; i++)
//    for (var j = 0; j < matrix[i].length; j++)
//      console.log(matrix[i][j] + ' ');
};

function DFA(signal, matrix) {
  var currenState = 0;
  for (var i = 0; i < signal.length; i++)  {
    if (signal[i] === 'a') {
      currenState = matrix[currenState][0];
      console.log('New state: ' + currenState);
    }
    else if (signal[i] === 'b') {
      currenState = matrix[currenState][1];
      console.log('New state: ' + currenState);
    }
  };
  console.log('Last state: ' + currenState);
  if (currenState > 0)
    console.log('Accepted');
  else if (currenState === 0)
    console.log('Rejected');
  else
    console.log('Something bad happened!');
};