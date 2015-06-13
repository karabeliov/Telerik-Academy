taskName = "Task 1";

function Main(bufferElement) {

    //#region Input
    var test1 =
        [
            '5 1',
            '9 0 2 4 1'
        ],
        test2 =
        [
            '10 3',
            '1 9 1 9 1 9 1 9 1 9'
        ],
        test3 =
        [
            '10 10',
            '0 1 2 3 4 5 6 7 8 9'

        ],
        result1 = 26
        , result2 = 365
        , result3 = 42;

    //#endregion 





    //#region Solution   
    function solve(params) {
        var result = 0, i, j, len;
        var nk = params[0].split(' ').map(Number),
            n = nk[0], k = nk[1],
            numbers = params[1].split(' ').map(Number);
        var first = 0, second = 0, current = 0, current1 = 0;
        var arr = [], arr1 = [], bigger;

        for (j = 0; j < k; j += 1) {
            for (i = 0; i < n; i += 1) {
                first = numbers[i - 1];
                second = numbers[i + 1];
                //debugger;
                if (first == undefined) {
                    first = 0;
                }

                if (second == undefined) {
                    second = 0;
                }

                current = isTransform(numbers[i], first, second);

                if (numbers[i] % 2 == 0) {
                    if (numbers[i + 1] == undefined) {
                        bigger = arr[p - 1];
                    }

                    if (numbers[i - 1] == undefined) {
                        bigger = numbers[i + 1];
                    }
                    else {
                        bigger = Math.max(numbers[i - 1], numbers[i + 1]);
                    }
                }
                else {
                    if (numbers[i - 1] == undefined) {
                        bigger = numbers[i + 1];
                    }

                    if (numbers[i + 1] == undefined) {
                        bigger = arr[p - 1];
                    }
                    else {
                        bigger = Math.min(numbers[i - 1], numbers[i + 1]);
                    }
                }

                console.log(bigger);
                result += bigger;
            }

            console.log(result);
            return result;
        }

        function isTransform(number, first, second) {
            if (number === 0) {
                number = Math.abs(first - second);
            }

            if (number === 1) {
                number = first + second;
            }

            return number;
        }
    }

    //#endregion





    //#region Output
    WriteLine("Result: " + solve(test1));

    //WriteLine("TEST1: " + (solve(test1) == result1));
    //WriteLine("TEST2: " + (solve(test2) == result2));
    //WriteLine("TEST3: " + (solve(test3) == result3));
    //#endregion
}