const fetch = require("node-fetch");

username = 'Samantha';
fetch(`https://jsonplaceholder.typicode.com/users?username=${username}`)
  .then(response => response.json())
  .then(users => {
    console.log('users:', users);   
  })
  .catch(error => {
    console.log('Request Error:', error);
  });
