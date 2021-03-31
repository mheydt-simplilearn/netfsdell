const number = 42;
try {
   number = 99;
} catch (err) {
   console.log(err);
}

console.log(number);
