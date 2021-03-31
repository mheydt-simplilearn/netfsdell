const square = x => x * x;
console.log(square(5));

const greet = () => {
  console.log('Arrow functions are concise');
};
greet();

const multiply = (a, b = 1) => a * b;
console.log(multiply(3, 4));  
console.log(multiply(3)); 

const greeting = (greeting, ...names) => {
  return `${greeting} ${names.join(", ")}!`;
}
console.log(greeting("Hello", "Steve", "Bill"));
console.log(greeting("Hello"));
