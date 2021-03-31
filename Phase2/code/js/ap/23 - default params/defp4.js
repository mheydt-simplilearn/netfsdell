function greet(name, greeting, message = `${greeting} ${name}`) {
    return [name, greeting, message];
 }
 
 console.log(greet('David', 'Hi'));
 console.log(greet('David', 'Hi', 'Happy Birthday!'));
 
 