const fetch = require("node-fetch");

async function get()
{
  var result = await fetch('https://api.chucknorris.io/jokes/random')
  console.log(result);
}

get()