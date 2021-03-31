function flippingACoin() {
    return new Promise((resolve, reject) => {
      const val = Math.round(Math.random() * 1); // 0 or 1, at random
  
      val ? resolve('Heads!!') : reject('Tails!!');
    });
  }
  
  async function result() {
    try {
      //const result = await flippingACoin();
      flippingACoin()
        .then(() => console.log('heads'))
        .reject(() => console.log('tails'))
      console.log(result);
    } catch(err) {
      console.log(err);
    }
  }
  
  result(); 
  result(); 
  result(); 
  result(); 
  result(); 
