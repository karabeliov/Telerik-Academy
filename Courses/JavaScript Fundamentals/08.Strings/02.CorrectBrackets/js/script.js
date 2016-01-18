// Write a JavaScript function to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
taskName = "Correct brackets";

function Main(bufferElement) {
// Input
    var expression = "((a+b)/5-d)"; // Change value to TEST
// Solution   
    function check(expression) {
        var openB = 0,
            closeB = 0,
            isCorrect = false;
        for (var i = 0; i < expression.length; i++) {
            if (expression[i] === '(') {
                openB++;
            }

            if (expression[i] === ')') {
                closeB++;
            }
        }

        if (openB === closeB) {
            isCorrect = true;
        }

        return isCorrect;
    }
    // Output
    WriteLine("Given expression " + expression);
    Write("This expression is ");
    WriteLine(check(expression) ? "correct" : "incorrect");
}