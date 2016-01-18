// Write a function that extracts the content of a html page given as text.
// The function should return anything that is in a tag, without the tags.
// Result: Sample sitetextmore textand more...in body
taskName = "Extract text from HTML";

function Main(bufferElement) {
// Input
    var html = "<html><head><title>Sample site</title></head><body><div>text<div>" + 
    "more text</div>and more...</div>in body</body></html>"; // Change value to TEST
// Solution   
    function readHTML(html) {
        return html.replace(/<.*?>/g, "");
    }

    // Output
    WriteLine("HTML document: " + html);
    WriteLine();
    WriteLine("Read HTML document: " + readHTML(html));
}