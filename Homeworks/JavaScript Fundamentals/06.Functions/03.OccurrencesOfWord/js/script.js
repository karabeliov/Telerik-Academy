// Write a function that finds all the occurrences of word in a text.
// The search can be case sensitive or case insensitive.
// Use function overloading.
taskName = "Occurrences of word";

function Main(bufferElement) {
// Input
    var text = "Write a function with JavaScript that finds all the occurrences of word in a text", // Change value to TEST
        word = "javascript",
        sensitive = false,
        occurrences = 0;
// Solution   
    function searchWord (text, word, sensitive) {
        var words = text.split(" "),
            counter = 0;
        if (sensitive) {
            for (var i = 0; i < words.length; i++) {
                if (words[i] === word) {
                    counter++;
                }
            }
        }
        else {
            for (var i = 0; i < words.length; i++) {
                if (words[i].toLowerCase() === word.toLowerCase()) {
                    counter++;
                }
            }
        }

        return counter;
    }
// Output
    WriteLine("Occurrences of word in a text: " + searchWord(text, word, sensitive));
}