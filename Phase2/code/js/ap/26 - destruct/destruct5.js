function userId({ id }) {
    return id;
 }
 
 function whois({ displayName, fullName: { firstName: name } }) {
    console.log(displayName + ' is ' + name);
 }
 
 var user = {
    id: 100,
    displayName: 'Jimmy22',
    fullName: {
       firstName: 'James',
       lastName: 'Halpert'
    }
 };
 
 console.log('userId: ' + userId(user)); 
 whois(user);
 