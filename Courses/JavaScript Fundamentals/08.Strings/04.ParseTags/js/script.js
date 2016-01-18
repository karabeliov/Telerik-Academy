// You are given a text. Write a function that changes the text in all regions:
taskName = "Parse tags";

function Main(bufferElement) {
    // Input                // Change value to TEST
    var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. " +
               "We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";
    // Solution   
    function htmlFormat(text) {
        debugger;
        var startIndex,
            endIndex,
            tag,
            position = 0,
            endIndexTag,
            newText = "",
            needText = "",
            beenHere = false;
        while (true) {
            startIndex = text.indexOf("<", position);
            endIndex = text.indexOf(">", position + 1);
            endIndexTag = text.indexOf("</", position + 1)
            tag = text.substring(startIndex, endIndex).replace("<", "");

            if (position === 0) {
                newText = text.substring(0, startIndex);
            }

            position = endIndex;
            
            if (position === -1) { // end loop
                break;
            }

            needText = text.substring(endIndex + 1, endIndexTag);

            if (tag === "upcase") {
                newText += needText.toUpperCase();
            }
            else if (tag === "mixcase") {
                if (beenHere) {
                    beenHere = false;
                    for (var i = 0; i < needText.length; i++) {
                        if (i % 2 !== 0) {
                            newText += needText[i].toUpperCase();
                        }
                        else {
                            newText += needText[i].toLowerCase();
                        }
                    }
                }
                else {
                    beenHere = true;
                    for (var i = 0; i < needText.length; i++) {
                        if (i % 2 === 0) {
                            newText += needText[i].toUpperCase();
                        }
                        else {
                            newText += needText[i].toLowerCase();
                        }
                    }
                }   
            }
            else if (tag === "lowcase") {
                newText += needText.toLowerCase();
            }
            else {
                startIndex = text.indexOf("<", position);
                if (startIndex != -1) {
                    newText += text.substring(endIndex, startIndex).replace(">", "");
                }
                else {
                    newText += text.substr(endIndex, text.length).replace(">", "");
                }
            }
        }

        return newText;
    }
    // Output
    WriteLine("HTML document: " + text);
    WriteLine();
    WriteLine("Read HTML document: " + htmlFormat(text));
}