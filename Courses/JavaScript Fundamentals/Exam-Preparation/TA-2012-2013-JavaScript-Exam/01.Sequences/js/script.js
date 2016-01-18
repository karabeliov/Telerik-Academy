taskName = "Sequences";

function Main(bufferElement) {
// Input
    var test1 = [
    7,
    1,
    2,
    -3,
    4,
    4,
    0,
    1
    ],
    test2 = [
        6,
        1,
        3,
        -5,
        8,
        7,
        -6
    ],
    test3 = [
        9,
        1,
        8,
        8,
        7,
        6,
        5,
        7,
        7,
        6
    ]
// Solution   
    function Solve(params) {
        var N = parseInt(params[0]);
        var answer = 0;
        for (var i = 2; i <= N; i++) {
            if (parseInt(params[i]) >= parseInt(params[i - 1])) {
                continue;
            }
            else {
                answer++;
            }
        }

        return ++answer;
    }

// Output
    WriteLine(Solve(test1));
    WriteLine(Solve(test2));
    WriteLine(Solve(test3));
}