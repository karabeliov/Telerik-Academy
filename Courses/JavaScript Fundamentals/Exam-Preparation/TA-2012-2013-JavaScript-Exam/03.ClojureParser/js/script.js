taskName = "ClojureParser";

function Main(bufferElement) {
// Input
    var input = '(def func 10)' +
    '(def newFunc (+  func 2))' +
    ' (def sumFunc (+ func func newFunc 0 0 0))' +
    '(* sumFunc 2)',
    test1 = '(+ 1 2)';
// Change value to TEST'
        
// Solution   
    function Solve(params) {

        function trimLast(str) {
            var i, len, result = '';
            for (i = 0, len = str.length; i < len; i++) {
                if (str[0] === '(' && i === 0) {
                    continue;
                }
                else if (str[len - 1] === ')' && i === len - 1) {
                    continue;
                }

                result += str[i];
            }

            return result;
        }
        result = sum;
        return result;
    }
    // Output

    WriteLine("Result: " + Solve(test1));
}