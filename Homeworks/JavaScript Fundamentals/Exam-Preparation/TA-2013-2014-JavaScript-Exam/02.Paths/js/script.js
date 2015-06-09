taskName = "Paths";

function Main(bufferElement) {
    // Input
    var test1 = [
 '3 5',
 'dr dl dr ur ul',
 'dr dr ul ur ur',
 'dl dr ur dl ur'
    ],
    test2 = [
 '3 5',
 'dr dl dl ur ul',
 'dr dr ul ul ur',
 'dl dr ur dl ur'
    ];
    // Solution   
    function solve(args) {
        var line1 = args[0].split(' '),
            rows = line1[0],
            cols = line1[1],
            count = 0,
            moves;
        args.shift();
        moves = args;
            var index = 0,
            starPosition = [0][0],
            row = 0,
            col = 0,
            j,k,
            matrix = [],
            counter = 1;

            for (j = 0; j < rows; j++) {
                matrix.push([]);
                for (k = 0; k < cols; k++) {
                    matrix[j][k] = count++;
                }
            }
    }
    // Output
    WriteLine(solve(test1));
    WriteLine(solve(test2));
}