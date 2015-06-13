taskName = "Task 1";

function Main(bufferElement) {

    //#region Input
    var test1 =
        [
           '4',
           '2',
           '1 3 1 8'
        ],
        test2 =
        [
            '5',
            '3',
            '7 7 8 9 10'
        ],
        test3 =
        [
            '8',
            '4',
            '1 8 8 4 2 9 8 11',
        ],
        result1 = '4,4,9'
        , result2 = '15,16,18'
        , result3 = '9,10,11,11,13';

    //#endregion 





    //#region Solution   
    function solve(params) {
        var result = 0, i, j, len;
        var N = parseInt(params[0]),
        K = parseInt(params[1]),
        numbersAsString = params[2].split(' '),
            arr = [];
        var min = 1000000000;
        var max = -1000000000;

        numbersAsString = numbersAsString.map(Number);
        for (i = 0, len = numbersAsString.length; i <= len - K; i += 1) {
            for (var j = 0; j < K; j++) {
                var currentMin = numbersAsString[j + i];
                var currentMax = numbersAsString[j + i];
                //debugger;
                if (currentMax > max) {
                    max = currentMax;
                }

                if (currentMin < min) {
                    min = currentMin;
                }
            }

            arr.push(min + max);
            min = 1000000000;
            max = -1000000000;

        }

        result = arr.join(',');
        return result;
    }

    //#endregion





    //#region Output
    WriteLine("Result: " + solve(test3));

    WriteLine("TEST1: " + (solve(test1) == result1));
    WriteLine("TEST2: " + (solve(test2) == result2));
    WriteLine("TEST3: " + (solve(test3) == result3));
    //#endregion
}