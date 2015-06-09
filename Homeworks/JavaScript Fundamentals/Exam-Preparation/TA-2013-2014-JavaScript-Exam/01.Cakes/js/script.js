taskName = "Cakes";

function Main(bufferElement) {
    // Input
    var test1 = [
        '110',
        '13',
        '15',
        '17'
    ],
    test2 = [
        '20',
        '11',
        '200',
        '300'
    ],
    test3 = [
        '110',
        '19',
        '29',
        '39'
    ]
    // Solution   
    function solve(params) {
        var price = +params[0], c1 = +params[1], c2 = +params[2], c3 = +params[3];
        var answer = 0,
            i, j, k, sum = 0;
        debugger;
        for (i = 0; i <= price / c1; i += 1) {
            for (j = 0; j <= price / c2; j += 1) {
                for (k = 0; k <= price / c3; k += 1) {
                    sum = (i * c1) + (j * c2) + (k * c3);
                    if (sum > answer && sum <= price) {
                        answer = sum;
                    }
                }
            }
        }

        return answer;
    }
    // Output
    WriteLine("TEST1: " + (solve(test1) === 110));
    WriteLine("TEST2: " + (solve(test2) === 11));
    WriteLine("TEST3: " + (solve(test3) === 107));
}