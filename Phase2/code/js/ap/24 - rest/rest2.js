function greet(greeting, ...names) {
    return `${greeting} ${names.join(", ")}!`;
 }
 
 console.log(greet("Hello", "Steve", "Bill"));
 console.log(greet("Hello"));
 