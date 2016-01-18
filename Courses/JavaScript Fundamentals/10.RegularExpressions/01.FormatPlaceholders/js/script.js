// Write a function that formats a string. The function should have placeholders, as shown in the example
// Add the function to the String.prototype
taskName = "Format with placeholders";

function Main(bufferElement) {
// Input
    var text = "My name is #{name} and I am #{age}-years-old'?", // Change value to TEST
        options = { name: 'John', age: 13 };
    // Solution   
    String.prototype.format = function stringFormat(str) {
        if (str.age === undefined) {
            return this.replace(/#{name}/g, str.name);
        }

        return this.replace(/#{name}/g, str.name).replace(/#{age}/g, str.age);
    };
    // Output
    WriteLine(text + "  " + JSON.stringify(options));
    WriteLine();
    WriteLine(text.format(options));
}