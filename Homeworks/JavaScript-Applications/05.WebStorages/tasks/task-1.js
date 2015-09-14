function solve() {

  function init(playerName, endCallback) {
    var numberGenerated = numberGenerator(); 
    var win = endCallback;
    
    this.playerName = playerName;
    this.score = 0;
    this.numberGenerated = numberGenerated;
    this.win = win;
  }

  function guess(number) {
    var guessNumber = number;
  }

  function getHighScore(count) {
    localStorage.setItem('Best Result', count.toString());
    
    return localStorage.getItem('Best Result');
  }

  function numberGenerator() {
    while (true) {
      var num = Math.floor((Math.random() * 10000));
      
      if (num >= 1000) {
        break;
      }
    }
    
    return num;
  }
  
  function checkForCows(numberGenerator, guessNumber) {
    var generated = numberGenerator.toString();
    var guess = guessNumber.toString();
    
    var count = 0;
    for (var index = 0; index < guess.length; index++) {
      var digitInGuessNumber = guess[index];
      
      count += (generated.match(new RegExp(digitInGuessNumber, "g")) || []).length;
    }
    
    return count;
  }
  
  function checkForBulls(numberGenerator, guessNumber) {
    var generated = numberGenerator.toString();
    var guess = guessNumber.toString();
    
    var count = 0;
    for (var index = 0; index < generated.length; index++) {
      var digitInGeneratedNumber = generated[index];
      var digitInGuessNumber = guess[index];
      
      if (digitInGeneratedNumber === digitInGuessNumber) {
          count++;
      }
    }
    
    return count;
  }
  
  return {
    init, guess, getHighScore
  }
}

module.exports = solve;
