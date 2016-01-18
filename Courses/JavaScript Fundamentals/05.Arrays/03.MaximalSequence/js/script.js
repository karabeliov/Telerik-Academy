// Write a script that finds the maximal sequence of equal elements in an array.
taskName = "Maximal sequence";

function Main(bufferElement) {
    // Input
    var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1], // Change value to TEST
        result = [];
    // Solution   
    for (var i = 1; i <= arr.length; i++) { // Full Array only with equel element
        if (arr[i - 1] === arr[i]) { 
            result.push(arr[i]);
            result.push(arr[i]);
        }
    }

    result.pop(result.length - 1);
    result.sort(); // sort element

    var currentSymbol,
        wantedSymbol,
        counter = 1,
        maxCount = 0;
    for (var i = 0; i < result.length; i++) {
        currentSymbol = result[i];

        if (currentSymbol === result[i + 1]) { 
            counter++;
            if (maxCount < counter ) {
                maxCount = counter; // take max count of equel element
                wantedSymbol = currentSymbol; // take element
            }
        }
        else { 
            counter = 1; // reset
        }   
    }

    result = []; // reset

    for (var i = 0; i < maxCount; i++) { // full array with maximal sequence of equal elements
        result[i] = wantedSymbol;
    }
    // Output
    WriteLine("Result: " + result.join(", "));
}