// Write a JavaScript function that finds how many 
// times a substring is contained in a given text (perform case insensitive search).
taskName = "Sub-string in text";

function Main(bufferElement) {
// Input
    var target = "in", // Change value to TEST
        text = "The text is as follows: We are living in an yellow submarine. " +
    "We don't have anything else. inside the submarine is very tight. " + 
    "So we are drinking all the day. We will move out of it in 5 days.",
        result;
    // Solution   
    function contained(target, text, sensitive) {
        var counter = 0,
            sensitive = sensitive || false,
            index = 0,
            targetL = target.length,
            findIndex,
            matches = [];

        if (sensitive) {
            while ((findIndex = text.indexOf(target, index)) > -1) {
                matches.push(findIndex);
                index = findIndex + targetL;
            }

            counter = matches.length;
        }
        else {
            text = text.toLowerCase();
            target = target.toLowerCase();

            while ((findIndex = text.indexOf(target, index)) > -1) {
                matches.push(findIndex);
                index = findIndex + targetL;
            }

            counter = matches.length;
        }

        return counter;
    }

    var result = contained(target, text, false);
    // Output
    WriteLine("Target: " + target);
    WriteLine();
    WriteLine("Text: " + text);
    WriteLine();
    WriteLine("Target word is have " + result + (result === 1 ? " time" : " times") + " in text!");
}