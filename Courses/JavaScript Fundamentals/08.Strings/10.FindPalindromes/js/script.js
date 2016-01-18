// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
taskName = "Find palindromes";

function Main(bufferElement) {
// Input
    var text = "SOS, BOB and potop they are palindromes like ABBA, lamal, exe"; // Change value to TEST
    // Solution   
    (function () { // this function trim char
        if (!String.prototype.trimLeftChars) {
            String.prototype.trimLeftChars = function (chars) {
                var regEx = new RegExp('^[' + chars + ']+');
                return this.replace(regEx, '');
            }
        }

        if (!String.prototype.trimRightChars) {
            String.prototype.trimRightChars = function (chars) {

                var regEx = new RegExp('[' + chars + ']+$');
                return this.replace(regEx, '');
            }
        }

        if (!String.prototype.trimChars) {
            String.prototype.trimChars = function (chars) {
                return this.trimLeftChars(chars).trimRightChars(chars);
            }
        }
    })();

    function searchPalindromes(text) {
        var matches = [],
            index = 0,
            allWords = text.split(" ");

        while (allWords[index] !== undefined) {
            var word = allWords[index].trimChars(",");
            for (var i = 0; i < word.length; i++) {
                if (word[i] !== word[word.length - 1 - i]) {
                    break;
                }
                else {
                    if (i === word.length - 1) {
                        matches.push(word);
                    }
                }
            }

            index++;
        }

        return matches;
    }
    // Output
    WriteLine("Text to search palindromes: " + text);
    WriteLine();
    WriteLine("Result of search: " + searchPalindromes(text).join(", "));
}