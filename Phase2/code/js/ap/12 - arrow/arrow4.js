let team = {
    players: ['Jeter', 'Ruth', 'Young', 'Bonds'],
    country: 'USA',
    display: function () {
       this.players.forEach(player => {
          console.log(`${player} is from ${this.country}`);
       });
    }
 };
 
 team.display();
 