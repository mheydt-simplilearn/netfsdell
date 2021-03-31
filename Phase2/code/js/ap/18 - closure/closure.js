var add = (function () {
    var counter = 0;
    return function () {
        counter += 1;
        console.log(counter) 
        return counter}
  })();
  
  add();
  add();
  console.log(add());
  console.log(add.counter)