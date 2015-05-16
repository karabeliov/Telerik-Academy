// Write a script that finds the greatest of given 5 variables.
// Use nested if statements.
taskName = "The biggest of five numbers";

function Main(bufferElement) {
    // Input
    var a = -3, // Change value to TEST
        b = -0.5,
        c = -1.1,
        d = -2,
        e = -0.1,
        biggest;
    // Solution
    if (a >= b) {
        biggest = a;
        if (biggest <= c) {
            biggest = c;
            if (biggest <= d) {
                biggest = d;
                if (biggest <= e) {
                    biggest = e;
                }
            }
            else {
                if (biggest <= e) {
                    biggest = e;
                }
            }
        }
        else {
            if (biggest <= d) {
                biggest = d;
                if (biggest <= e) {
                    biggest = e;
                }
            }
            else {
                if (biggest <= e) {
                    biggest = e;
                }
            }
        }
    }
    else {
        biggest = b;
        if (biggest <= c) {
            biggest = c;
            if (biggest <= d) {
                biggest = d;
                if (biggest <= e) {
                    biggest = e;
                }
            }
            else {
                if (biggest <= e) {
                    biggest = e;
                }
            }
        }
        else {
            if (biggest <= d) {
                biggest = d;
                if (biggest <= e) {
                    biggest = e;
                }
            }
            else {
                if (biggest <= e) {
                    biggest = e;
                }
            }
        }
    }
    // Output
    WriteLine("Biggest = " + biggest);
}