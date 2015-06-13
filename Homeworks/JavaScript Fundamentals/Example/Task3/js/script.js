taskName = "Task3";

function Main(bufferElement) {

    //#region Input
    var test1 =
        [
            '#the-big-b{',
            'color: yellow;',
            'size: big;',
            '}',
            '.muppet{',
            '    skin: fluffy; ',
            '}',
            'all{',
            '    meant-for: nerdy-children;',
            '}'
        ],
        test2 =
        [
            '#the-big-b{',
            'color: yellow;',
            ' size: big;',
            '}',
            '.muppet{',
            '    powers: all;',
            '    skin: fluffy;',
            '}',
            '.water-spirit         {',
            '    powers: water;',
            '    alignment    : not-good;',
            '}',
            'all{',
            '    meant-for: nerdy-children;',
            '}',
            '.muppet      {',
            '    powers: everything;',
            '}',
            'àll            .muppet {',
            '    alignment             :             good                             ;',
            '}',
            '.muppet+             .water-spirit{',
            '    power: everything-a-muppet-can-do-and-water;',
            '}'
        ],
        test3 =
        [

        ],
        result1 = '#the-big-b{color:yellow;size:big}.muppet{skin:fluffy;powers:everything}.water-spirit{powers:water;alignment:not-good}all{meant-for:nerdy-children}all. muppet{alignment:good}.muppet+.water-spirit{power:everything-a-muppet-can-do-and-water}'

        , result2, result3;
    //#endregion 





    //#region Solution   
    function solve(args) {
        var result = '', i, j, len, lineBreak;
        for (i = 0, len = args.length; i < len; i += 1) {
            var line = args[i].trim();
            //console.log(line);

            for (j = 0, lineBreak = line.length; j < lineBreak; j += 1) {
                var currentSymbol = line[j].trim();
             
                debugger;
                if (currentSymbol == ';') {
                    currentSymbol = '';
                }

                result += currentSymbol;
            }
        }

        console.log(result);
        console.log(result1);
        return result;
    }
    //#endregion





    //#region Output
    WriteLine("Result: " + solve(test2));

    //WriteLine("TEST1: " + (solve(test2) == result1));
    //WriteLine("TEST2: " + (solve(test2) === result2));
    //WriteLine("TEST3: " + (solve(test3) === result3));
    //#endregion
}