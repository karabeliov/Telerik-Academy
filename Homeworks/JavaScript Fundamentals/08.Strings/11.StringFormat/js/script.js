// Write a function that formats a string using placeholders.
// The function should work with up to 30 placeholders and all types.
taskName = "String format";

function Main(bufferElement) {
// Input
    var string = "'Hello {0}!', 'Peter'"; // Change value to TEST
// Solution   
    function stringFormat(str) {
        var argument = arguments;

        return str.replace(/\{(\d+)}/g, function (match, arg) {
            return argument[+arg + 1];
        })
    }
// Output
    WriteLine("Result: " + stringFormat('{1} said: "Hello" to {0}!', 'Peter', 'Niki'));
}