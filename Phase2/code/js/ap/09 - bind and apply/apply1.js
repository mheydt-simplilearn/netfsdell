var person = {
    fullName: function() {
      return this.firstName + " " + this.lastName;
    }
}

console.log(person.fullName());

var person1 = {
    firstName: "Mary",
    lastName: "Doe"
}

console.log(person.fullName.apply(person1)); 
