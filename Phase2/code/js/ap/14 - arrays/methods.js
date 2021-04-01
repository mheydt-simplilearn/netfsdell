var fruits = ["Banana", "Orange", "Apple", "Mango"];
console.log(fruits.join(" * "));

console.log(fruits.pop());
console.log(fruits);

var fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.push("Kiwi");
console.log(fruits);

var fruits = ["Banana", "Orange", "Apple", "Mango"];
var x = fruits.push("Kiwi"); 
console.log(x);

var fruits = ["Banana", "Orange", "Apple", "Mango"];
var x = fruits.shift();
console.log(x);
console.log(fruits)

var fruits = ["Banana", "Orange", "Apple", "Mango"];
var x = fruits.unshift("Lemon"); 
console.log(x);
console.log(fruits);

console.log(fruits.length);

delete fruits[1];
console.log(fruits);
console.log(fruits[10])
fruits[10] = 'Raspberry'
console.log(fruits)

var fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.splice(2, 0, "Lemon", "Kiwi");
console.log(fruits);

var fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.splice(2, 2, "Lemon", "Kiwi");
console.log(fruits);

var fruits = ["Banana", "Orange", "Lemon", "Apple", "Mango"];
var citrus = fruits.slice(3);
console.log(citrus);
console.log(fruits);

var fruits = ["Banana", "Orange", "Lemon", "Apple", "Mango"];
var citrus = fruits.slice(1, 3);
console.log(citrus);
console.log(fruits);

var a = [10, 1, 100, -50]
console.log(Math.min(...a))
