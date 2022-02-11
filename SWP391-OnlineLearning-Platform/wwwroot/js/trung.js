var test = true;

function otherTest() {
  return true;
}

addEventListener('beforeunload', function(event) {
if(!test || !otherTest()) {
  event.returnValue = 'You have unsaved changes.';
}
  
});

document.getElementById('theButton').addEventListener('click', function(event) {
  test = !test;
  this.innerHTML = test.toString();
});


var hours = 0, // obtain these values somewhere else 
  minutes = 1,
  seconds = 20,
  target = new Date(),
  timerDiv = document.getElementById("timer"),
  handler;

function init() { 
 // set the target date time with the counter values
 // counters more then 24h should have a date setup or it wont work
  target.setHours(hours);
  target.setMinutes(minutes);
  target.setSeconds(seconds);
  target.setMilliseconds(0); // make sure that miliseconds is 0
  timerDiv.innerHTML = target.toTimeString().split(" ")[0]; // print the value
}

function updateTimer() {
  var time = target.getTime();
  target.setTime(time - 1000); // subtract 1 second with every thick
  timerDiv.innerHTML = target.toTimeString().split(" ")[0];
  if (
    target.getHours() === 0 &&
    target.getMinutes() === 0 &&
    target.getSeconds() === 0
  ) { // counter should stop
  $('#theButton').click();
    clearInterval(handler);
  }
}

handler = setInterval(updateTimer, 1000);

document.getElementById("stop-button").addEventListener("click", function() {
  clearInterval(handler);
});
document.getElementById("start-button").addEventListener("click", function() {
  clearInterval(handler);
  handler = setInterval(updateTimer, 1000);
});
document.getElementById("reset-button").addEventListener("click", function() {
  init();
  clearInterval(handler);
});
init();