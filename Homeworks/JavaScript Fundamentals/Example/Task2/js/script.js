taskName = "Task2";

function Main(bufferElement) {

    //#region Input
    var test1 =
        [


        ],
        test2 =
        [

        ],
        test3 =
        [

        ],
        result1, result2, result3;
    //#endregion 





    //#region Solution   
    function solve(args) {
        var result, i, len;

        function solve(params) {
            var rows = parseInt(params[0]),
                cols = parseInt(params[1]),
                tests = parseInt(params[rows + 2]), i, move;
            for (i = 0; i < tests; i += 1) {
                move = params[rows + 3 + i];
                // Your solution here
                console.log('yes'); // or console.log('no');
            }
        }

        return result;
    }
    //#endregion





    //#region Output
    WriteLine("Result: " + solve(test1));

    WriteLine("TEST1: " + (solve(test1) === result1));
    WriteLine("TEST2: " + (solve(test2) === result2));
    WriteLine("TEST3: " + (solve(test3) === result3));
    //#endregion
}