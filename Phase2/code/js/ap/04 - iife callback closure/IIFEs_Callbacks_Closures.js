//IIFE and Closure
for (var i = 0; i < 5; i++) {
  setTimeout(function() {
      console.log(i);
  }, 1000);
}
for (let i = 0; i < 5; i++) {
  setTimeout(function() {
      console.log(i);
  }, 1000);
}

for (var i = 0; i < 5; i++) {
  (function(i) {
      setTimeout(function() {
          console.log(i);
      }, 1000);
  })(i);
}

const empId2 = function() {
  var count = 0;
    ++count;
    return `emp${count}`;
}

const empId = (function() {
  var count = 0;
  
  return function() {
    ++count;
    return `emp${count}`;
  };
})();

console.log('hi');
//iife();
  
  console.log("New Emplyee IDs are listed here");
  console.log("Alex: "+empId()); 
  console.log("Dexter: "+empId()); 
  console.log("Annie: "+empId());
   

  //Callbacks
  console.log("\n"); //to start the output from the neext line
  function fullName(firstName, lastName, callback){
    console.log("My name is " + firstName + " " + lastName);
    callback(lastName);
  }
  
  var greeting = function(ln){
    console.log('Welcome ' + ln);
  };
  
  fullName("Alex", "Wilson", greeting);
  console.log("\n");
  fullName("Dexter", "Johnson", greeting);
  console.log("\n");
  fullName("Annie", "Butler", greeting);
