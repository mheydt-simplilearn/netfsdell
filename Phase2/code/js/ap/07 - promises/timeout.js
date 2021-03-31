const wait = ms => new Promise(
    resolve => {
        setTimeout(resolve, ms)
    });
function saySomething(x) { console.log(x);}
wait(1*1000).then(() => saySomething("10 seconds")).catch(() => {});