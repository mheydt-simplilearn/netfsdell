const object = { a: 1, b: 2, c: 3, foo: "bar" };

for (const property in object) {
  console.log(`${property}: ${object[property]}`);
}