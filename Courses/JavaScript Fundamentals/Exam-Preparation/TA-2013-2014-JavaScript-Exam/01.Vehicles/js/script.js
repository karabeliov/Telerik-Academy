taskName = "Vehicles";

function Main(bufferElement) {
    // Input
    var tests = [['7'], ['10'],['40']];
    // Solution   
    function solve(params) {
        var s = +params[0];
        var count = 0;
        var i, j, k;

        for (i = 0; i <= s / 10; i += 1) { // 10
            for (j = 0; j <= s / 4; j += 1) { // 4
                for (k = 0; k <= s / 3; k += 1) { // 3
                    if ((i * 10 + j * 4 + k * 3) === s) {
                        count += 1;
                    }
                }
            }
        }

        return count;
    }
    // Output
    tests.forEach(function (test) {
        WriteLine(solve(test));
    });
}