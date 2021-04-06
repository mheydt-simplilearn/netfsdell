console.log('starting');
const wait = ms => new Promise(
    resolve => {
        setTimeout(resolve, ms)
    });
function saySomething(x) { console.log(x);}
wait(3*1000)
    .then(() => saySomething("3 seconds"))
    .catch(() => {});
console.log('done')