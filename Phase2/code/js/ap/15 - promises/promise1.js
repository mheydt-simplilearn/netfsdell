var XMLHttpRequest = require("xmlhttprequest").XMLHttpRequest;

function getData(url) {
    return new Promise((resolve, reject) => {
      const xhr = new XMLHttpRequest();
      xhr.open('GET', url);
      xhr.onload = () => resolve(xhr.responseText);
      xhr.onerror = () => reject(xhr.statusText);
      xhr.send();
    });
  }
  
  // Using a Promise object
  getData('https://jsonplaceholder.typicode.com/users/1')
    .then(data => {
      console.log('XHR Request Successful!');
      console.log('Data:', data);
    })
    .catch(error => {
      console.log('XHR Request Failed!');
      console.log('Error:', error);
    });
  