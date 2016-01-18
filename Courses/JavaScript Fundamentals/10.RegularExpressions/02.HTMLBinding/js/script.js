// Write a function that puts the value of an object into the content/attributes of HTML tags.
// Add the function to the String.prototype
taskName = "HTML binding";

function Main(bufferElement) {
// Input
    var str = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>';  // Change value to TEST
    
// Solution   
    String.prototype.bind = function bind(str, obj) {
        if (obj.link !== undefined) {
            return str.replace(/><\//, ' href="' + obj.link + '"' + ' class="' + obj.name + '"' + '>' + obj.name + '</');
        }

        return str.replace(/><\//, ">" + obj.name + "</");
    }
    // Output
     WriteLine(str);
     WriteLine();
     WriteLine(str.bind(str, {name: 'Elena', link: 'http://telerikacademy.com'}));
}