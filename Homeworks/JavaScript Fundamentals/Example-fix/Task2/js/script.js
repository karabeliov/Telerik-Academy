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
        ],
        result2 = '4253274252525';

    //#endregion 





    //#region Solution   
    function solve(args) {
        var i, j, len;
        var result, compressText, encrypText, transformText,
        text = args[0],
        offset = args[1],
        CONSTANTS = {
            ALPHABET: 'abcdefghijklmnopqrstuvwxyz'
        }

        compressText = compression(text); 
        encrypText = encryption(compressText, offset, CONSTANTS.ALPHABET);
        transformText = transform(encrypText)

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

        function encryption(text, key, alphabet) {           
            var kcount = 26 - key;
            var encryp = '';
            
            for (var i = 0, len = text.length; i < len; i += 1) {
                var codeChar = text.charCodeAt(i);
                if (+text[i]) {
                    encryp += text[i];
                }
                else {
                    var edit = codeChar ^ codeChar + kcount;
                    encryp += edit;
                }
            }

            return encryp;
        }

        function transform(text) {
            var sum = 0, product = 1;
            var result = '';
            for (var i = 0, len = text.length; i < len; i += 1) {
                var currentDigit =  +text[i];
                if (currentDigit % 2 == 0) {
                    sum += currentDigit;
                }
                else {
                    product *= currentDigit;
                }
            }

            result += sum + '\n' + product;
            return result;
        }

        result = transformText;
        return result;
    }

    //#endregion





    //#region Output
    WriteLine("Result: " + solve(test1));
    //#endregion
}