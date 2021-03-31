class Animal {
    constructor(name) {
       this.name = name;
    }
    move(distanceInMeters = 0) {
       console.log(`${this.name} moved ${distanceInMeters}m.`);
    }
 }
 class Dog extends Animal {
    bark() {
       console.log('Woof! Woof!');
    }
 }
 const dog = new Dog('Cooper');
 dog.bark();    
 dog.move(10);
 