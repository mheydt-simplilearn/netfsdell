const cities = ['New York', 'London', 'Paris', 'Amsterdam'];

let [c1, c2, ...rest1] = cities;

console.log(c1);    
console.log(c2);    
console.log(rest1);

let { a, b, ...rest2 } = { a: 10, b: 20, c: 30, d: 40 }
console.log(a); 
console.log(b);  
console.log(rest2);
