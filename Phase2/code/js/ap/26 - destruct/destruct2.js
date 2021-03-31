let a, b;
[a, b] = [1, 2];
console.log(a);  
console.log(b); 

var x, y;
[x = 10, y = 20] = [1];
console.log(x);  
console.log(y);

let p, q;
({ p, q } = { p: 1, q: 2 });
console.log(p);  
console.log(q);

let o = { l: 42, m: true };
let { l: foo, m: bar } = o;
console.log(foo);  
console.log(bar);

let { c = 10, d = 5 } = { c: 3 };
console.log(c);  
console.log(d);

var { a: aa = 10, b: bb = 5 } = { a: 3 };
console.log(aa); 
console.log(bb);
