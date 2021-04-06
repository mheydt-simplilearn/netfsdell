async function myAsync(){
    var promise = new Promise(resolve => {
        setTimeout(() => {
          resolve('resolved');
        }, 2000);
      });

      return await promise();
}

await myAsync();