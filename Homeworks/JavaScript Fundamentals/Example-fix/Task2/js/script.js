taskName = "Task 2";

function Main(bufferElement) {

    //#region Input
    var test1 =
        [
            'aaaabbbccccaa',
            '3'
        ],
        result1 =
        [
            '18',
            '13125'
        ];

    //#endregion 





    //#region Solution   
    function solve(args) {
        var i, j, len;
        var result, compressText, encrypText, transformText, newAphabet = '',
        text = args[0],
        offset = 3, // Warning
        CONSTANTS = {
            ALPHABET: 'abcdefghijklmnopqrstuvwxyz'
        }

        newAphabet = makeAphabet(CONSTANTS.ALPHABET.toString(), offset);
        compressText = compression(text); // do to return
        encrypText = encryption(compressText, newAphabet);
        transformText = transform(encrypText)
        //debugger;
        function compression(text) { 
            var compress = '';
            var count = 1;
            for (i = 1, len = text.length; i <= len; i += 1) {
                var prevSymbol = text[i - 1];
                var currentSymbol = text[i];
                if (currentSymbol == ' ') {
                    continue;
                }

                if (currentSymbol == undefined) {
                    currentSymbol = '';
                }

                if (prevSymbol == currentSymbol) {
                    count++;
                }
                else {
                   // debugger;
                    if (count > 2) {
                        compress += count + prevSymbol;
                    }
                    else if (count == 2) {
                       
                        compress += prevSymbol + prevSymbol;
                    }
                    else {
                        compress += prevSymbol;
                    }

                    count = 1;
                }
            }
            return compress;
        }

        function encryption(text, key) {           
            var kcount = key;

            var encryp = '';
           //debugger;
            
            for (var i = 0, len = text.length; i < len; i += 1) {
                //debugger;

                if (+text[i]) {
                    encryp += text[i];
                    //console.log('yes');
                }
                else {
                    var edit = text.charCodeAt(i) ^ key.charCodeAt(26 - kcount);
                    kcount--;
                    encryp += edit;
                }
            }
            console.log(encryp);
            return encryp;
        }

        function transform(text) {
            var sum = 0, product = 1;
            var result = '';
            for (var i = 0, len = text.length; i < len; i += 1) {
                //debugger;
                sum += +text[i];
                product *= +text[i];
            }

            result += sum + '\n' + product;
            return result;
        }

        function makeAphabet(text, key) {
            var alpha = [];
            for (var j = 0, len = text.length; j < len; j++) {
                if (j == key) {
                    break;
                }

                alpha.push(text[len - j - 1]);
            }

            var reverse = alpha.reverse().join('').toString() + text;

            return reverse;

        }

        result = transformText;
        //console.log(result);
        return result;
    }

    //#endregion





    //#region Output
    WriteLine("Result: " + solve(test1));

    WriteLine("TEST1: " + (solve(test1) == result1));
    //#endregion
}