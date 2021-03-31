let a, b, rest;
[a, b] = [10, 20];
console.log(a); // 10
console.log(b); // 20

[a, b, ...rest] = [10, 20, 30, 40, 50];
console.log(a); // 10
console.log(b); // 20
console.log(rest); // [30, 40, 50]

({ a, b } = { a: 10, b: 20 });
console.log(a); // 10
console.log(b); // 20

// Stage 4(finished) proposal
({a, b, ...rest} = {a: 310, b: 320, c: 330, d: 340});
console.log(a); // 10
console.log(b); // 20
console.log(rest); // {c: 30, d: 40}

const data = {name: 'Raj', age: 28};
console.log(data);
const {name:myName, age:myAge} = data;
console.log(myName, myAge);
