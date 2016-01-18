// Write a function to count the number of div elements on the web page
taskName = "Number of elements";

function Main(bufferElement) {
    // Input   
    var searchElement = "div"; // Change value to TEST
    // Solution   
    function getCount(element) {
        var elements = document.getElementsByTagName(element);
        return elements.length;
    }
    // Output
    WriteLine(Format("Number of '{0}' elements in this HTML document is: {1}.", searchElement, getCount(searchElement)));
}