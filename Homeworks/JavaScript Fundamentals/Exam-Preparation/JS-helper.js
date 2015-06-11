// Create Matrix
function matrix( rows, cols, defaultValue){

  var arr = [];

  // Creates all lines:
  for(var i=0; i < rows; i++){

      // Creates an empty line
      arr.push([]);

      // Adds cols to the empty line:
      arr[i].push( new Array(cols));

      for(var j=0; j < cols; j++){
        // Initializes:
        arr[i][j] = defaultValue;
      }
  }

return arr;
}

// sort numbers
 array.sort(function(a, b) {return a - b});
 
 // пълнене на двумерен масив(матрица) :
var matrix = [], rows = 5, cols = 5 ,row , col , count ;
for(row = 0; row < rows; row += 1) {
     matrix.push( [] );
      for ( col = 0; col < cols; col += 1){
           matrix[row][col] = count;
           count += 1;
     }
}


// ако искаме да копираме масив и новия да не е с референция към стария ,а да е изцяло нов:
var numbers = [5, 6, 7, 8, 9];
var copy = numbers.slice();
numbers[1] = 100;
console.log(numbers); // [5,100,7,8,9];
console.log(copy); // [5,6,7,8,9];

// четене на вход като матрица по редове
var lines = ['1 2 3',
                     '4 5 6'];
        var matrix = lines.map(function(line) {
            return line.split(' ')
                    .map(Number);
        });
// selection sort
var arr =  [8, 12, 3, 4, 5, 2, 11, 13, 7, 4, 15, 14, 12, 8, 1];
selectionSort(arr);
console.log(arr);

function selectionSort(arr) {
	for (var i = 0; i < arr.length; i+=1) {
		for (var j = i + 1; j < arr.length; j+=1) {
			if (arr[i] > arr[j]) {
				var tmp = arr[j];
				arr[j] = arr[i];
				arr[i] = tmp;
			}
		}
	}
}

// пълнене на матрица по редове и колони
lab = args.slice(1).map(function(line) {
      return line.split(' ');
    })
	
	
// метода find върху масив // MDN
if (!Array.prototype.find) {
    Array.prototype.find = function(predicate) {
        if (this == null) {
            throw new TypeError('Array.prototype.find called on null or undefined');
        }
        if (typeof predicate !== 'function') {
            throw new TypeError('predicate must be a function');
        }
        var list = Object(this);
        var length = list.length >>> 0;
        var thisArg = arguments[1];
        var value;

        for (var i = 0; i < length; i++) {
            value = list[i];
            if (predicate.call(thisArg, value, i, list)) {
                return value;
            }
        }
        return undefined;
    };
}	
	
/*
1. Да си направя три .js файла със следните templates:
function solve(input) {
    var len = input.length;
}
var test1 = [];
var test2 = [];
console.log(solve(test1));
console.log('-------------------------') // за да са ми отделени решенията на два теста 
console.log(solve(test2));
2. При задачите със стрингове е хубаво да се прави trim() колкото е възможно по-често или още в началото един цял replace на всички multiwhite-spaces с един:
string = string.replace(/  +/g, ' ');
3. Превръщане на стрингово число в number число: '21' * 1 = 21;
4. Да се внимава, ако в задачата има няколко for цикъла, да се използва i, j , k, m... да не се използва повторно i примерно, че може да стане мазало от горния for цикъл :)
5. Да се внимава и със търсенето на мин и макс. На първоначалните стойности да се присвояват +Infinity и -Infinity, че MIN_VALUE и MAX_VALUE не са типичните мин и макс валюта :) (виж. лекциите).
6. При обхождане на матрица, и ако се опитаме да вземем matrix[i+1][j+1], ако i+1 не съществъва (i + 1 === undefined), то ще гръмне, и аз лично съм се чудил 5 часа защо гърми :) изводът е първо да се провери дали i+1 съществува :)
7. Да се избягват Math... blah blah blah.. че са много бавни и може bgcoder да гръмне за време. Има си алтернативи. Math.floor == 22.3 | 1 (22). Math.pow == един for цикъл.
8. При стринговите задачи да се ползва автомат (символ по символ да се гледа и да се правят 15 хиляди if). (Задачите със стрингове могат и да се решават с парсване, но може да стане голямо мазало там) (Надявам се трейнърите да се смилят и да дадат малко по-не толкова завъртяни задачи, и да могат да се решават на части, примерно).
*/

