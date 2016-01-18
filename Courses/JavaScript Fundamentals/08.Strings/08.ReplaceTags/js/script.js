// Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> 
// with corresponding tags [URL=…]…/URL].
taskName = "Replace tags";

function Main(bufferElement) {
    // Input
    var html = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. ' +
    'Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>'; // Change value to TEST
    // Solution   
    function replace(html) {
        var result;
        result = html.replace(/<a href="/g, "[URL=")
        .replace(/">/g, "]")
        .replace(/<\/a>/g, "[/URL]");

        return result;
    }
    // Output
    WriteLine("Input: " + html);
    WriteLine();
    WriteLine("Output: " + replace(html));
}