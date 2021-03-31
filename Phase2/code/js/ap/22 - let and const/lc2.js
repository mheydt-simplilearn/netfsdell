var x = 1;
let y = 1;

if (true) {
   console.log('Inside the block');
   var x = 2;
   console.log(x);
   let y = 2;
   console.log(y);
}
console.log('Outside the block');
console.log(x);
console.log(y);
