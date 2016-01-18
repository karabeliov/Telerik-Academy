// Write a function that replaces non breaking white-spaces in a text with &nbsp;
taskName = "nbsp";

function Main(bufferElement) {
// Input
    var text = "JavaScript is very  cool   language!", // Change value to TEST
        escapeSymbol = "&nbsp;"; 
// Solution   
    function whiteSpace(text, symbol) {
        var result = text.replace(/ /g, symbol);
        return result;
    }
    // Output
    WriteLine("Original text: " + text);
    WriteLine("");
    WriteLine("Result: " + whiteSpace(text, escapeSymbol));
}