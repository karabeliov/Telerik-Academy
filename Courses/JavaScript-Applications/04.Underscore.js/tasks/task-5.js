/* 
Create a function that:
*   **Takes** an array of animals
    *   Each animal has propeties `name`, `species` and `legsCount`
*   **finds** and **prints** the total number of legs to the console in the format:
    *   "Total number of legs: TOTAL_NUMBER_OF_LEGS"
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (animals) {
    var _ = require('../node_modules/underscore/underscore-min.js');
    var legs = 0;
    _.chain(animals)
      .each(function(animal) {
        legs += animal.legsCount;
      });
      
      console.log('Total number of legs: ' + legs);
  };
}

module.exports = solve;