//Write a script that converts a number in the range [0…999] to words, 
//corresponding to its English pronunciation.
taskName = "Number as words";

function Main(bufferElement) {
    // Input
    var number = 808, // Change value to TEST
        output;
    // Solution   
    //#region Numbers (100-999)
    if (number < 1000 && number >= 100) {
        switch (Math.floor((number / 100) % 10)) {
            default: output = "not a digit";
                break;
            case 1:
                output = "One" + " hungred";
                break;
            case 2:
                output = "Two" + " hungred";
                break;
            case 3:
                output = "Three" + " hungred";
                break;
            case 4:
                output = "Four" + " hungred";
                break;
            case 5:
                output = "Five" + " hungred";
                break;
            case 6:
                output = "Six" + " hungred";
                break;
            case 7:
                output = "Seven" + " hungred";
                break;
            case 8:
                output = "Eight" + " hungred";
                break;
            case 9:
                output = "Nine" + " hungred";
                break;
        }

        switch (Math.floor((number / 10) % 10)) {
            default: output = "not a digit";
                break;
            case 0:
                output += " ";
                break;
            case 1:
                switch (Math.floor((number / 1) % 10)) {
                    default: output = "not a digit";
                        break;
                    case 0:
                        output += " and ten";
                        break;
                    case 1:
                        output += " and eleven";
                        break;
                    case 2:
                        output += " and twelve";
                        break;
                    case 3:
                        output += " and thirteen";
                        break;
                    case 4:
                        output += " and fourteen";
                        break;
                    case 5:
                        output += " and fifteen";
                        break;
                    case 6:
                        output += " and sixteen";
                        break;
                    case 7:
                        output += " and seventeen";
                        break;
                    case 8:
                        output += " and eighteen";
                        break;
                    case 9:
                        output += " and nineteen";
                        break;
                }
                output += "";
                break;
            case 2:
                output += " and twenty";
                break;    
            case 3:       
                output += " and thirty";
                break;    
            case 4:       
                output += " and fourty";
                break;    
            case 5:       
                output += " and fifty";
                break;    
            case 6:       
                output += " and sixty";
                break;    
            case 7:       
                output += " and seventy";
                break;    
            case 8:       
                output += " and eighty";
                break;    
            case 9:       
                output += " and ninety";
                break;
        }

        switch (Math.floor((number / 1) % 10)) {
            case 0:
                output += "";
                break;
            case 1:
                output += " one";
                break;
            case 2:
                output += " two";
                break;
            case 3:
                output += " three";
                break;
            case 4:
                output += " four";
                break;
            case 5:
                output += " five";
                break;
            case 6:
                output += " six";
                break;
            case 7:
                output += " seven";
                break;
            case 8:
                output += " eight";
                break;
            case 9:
                output += " nine";
                break;
        }
    }
    //#endregion Numbers (20-99)
    //#region Numbers (20-99)
    else if (number < 100 && number >= 20) {
        switch (Math.floor((number / 10) % 10)) {
            default: output = "not a digit";
                break;
            case 2:
                output = "Twenty";
                break;
            case 3:
                output = "Thirty";
                break;
            case 4:
                output = "Fourty";
                break;
            case 5:
                output = "Fifty";
                break;
            case 6:
                output = "Sixty";
                break;
            case 7:
                output = "Seventy";
                break;
            case 8:
                output = "Eighty";
                break;
            case 9:
                output = "Ninety";
                break;
        }

        switch (Math.floor((number / 1) % 10)) {
            case 0:
                output = "";
                break;
            case 1:
                output += " one";
                break;
            case 2:
                output += " two";
                break;
            case 3:
                output += " three";
                break;
            case 4:
                output += " four";
                break;
            case 5:
                output += " five";
                break;
            case 6:
                output += " six";
                break;
            case 7:
                output += " seven";
                break;
            case 8:
                output += " eight";
                break;
            case 9:
                output += " nine";
                break;
        }
    }
        //#endregion Numbers (20-99)
    //#region Numbers (10-19)
    else if (number < 20 && number >= 10) {
        switch (number) {
            default: output = "not a digit";
                break;
            case 10:
                output = "Ten";
                break;
            case 11:
                output = "Eleven";
                break;
            case 12:
                output = "Twelve";
                break;
            case 13:
                output = "Thirteen";
                break;
            case 14:
                output = "Fourteen";
                break;
            case 15:
                output = "Fifteen";
                break;
            case 16:
                output = "Sixteen";
                break;
            case 17:
                output = "Seventeen";
                break;
            case 18:
                output = "Eighteen";
                break;
            case 19:
                output = "Nineteen";
                break;
        }
    }
    //#endregion Numbers (10-19)
    //#region Digit (0-9)
    if (number < 10 && number >= 0) {
        switch (number) {
            default: output = "not a digit";
                break;
            case 0:
                output = "Zero";
                break;
            case 1:
                output = "One";
                break;
            case 2:
                output = "Two";
                break;
            case 3:
                output = "Three";
                break;
            case 4:
                output = "Four";
                break;
            case 5:
                output = "Five";
                break;
            case 6:
                output = "Six";
                break;
            case 7:
                output = "Seven";
                break;
            case 8:
                output = "Eight";
                break;
            case 9:
                output = "Nine";
                break;
        }
    }
    //#endregion Digit (0-9)      
    // Output
    WriteLine(number + " -> " + output);
}