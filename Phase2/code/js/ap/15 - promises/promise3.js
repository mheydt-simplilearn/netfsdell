const fetch = require("node-fetch");

username = 'Samantha';
fetch(`https://jsonplaceholder.typicode.com/users?username=${username}`)
  .then(response => response.json())
  .then(users => {
    console.log('user:', users[0]);   
    return fetch(`https://jsonplaceholder.typicode.com/posts?userId=${users[0].id}`)
  })
  .then(response => response.json())
  .then(posts => {
    console.log('posts:', posts);  
  })
  .catch(error => {
    console.log('Request Error:', error);
  });
