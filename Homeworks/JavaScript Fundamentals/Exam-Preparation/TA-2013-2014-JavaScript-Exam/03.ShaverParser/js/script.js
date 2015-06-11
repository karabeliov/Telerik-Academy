taskName = "Shaver Parser";

function Main(bufferElement) {
    // Input
    var test1 = [
    '6',
    'title:Telerik Academy',
    'showSubtitle:true',
    'subTitle:Free training',
    'showMarks:false',
    'marks:3,4,5,6',
    'students:Pesho,Gosho,Ivan',
    '42',
    '@section menu {',
    '    <ul id="menu">',
    '        <li>Home</li>',
    '        <li>About us</li>',
    '    </ul>',
    '}',
    '@section footer {',
    '    <footer>',
    '        Copyright Telerik Academy 2014',
    '    </footer>',
    '}',
    '<!DOCTYPE html>',
    '<html>',
    '<head>',
    '    <title>Telerik Academy</title>',
    '</head>',
    '<body>',
    '    @renderSection("menu")',
    '',
    '    <h1>@title</h1>',
    '@if (showSubtitle) {',
    '    <h2>@subTitle</h2>',
    '    <div>@@JustNormalTextWithDoubleKliomba ;)</div>',
    '}',
    '',
    '<ul>',
    '    @foreach (var student in students) {',
    '        <li>',
    '            @student ',
    '        </li>',
    '        <li>Multiline @title</li>',
    '    }',
    '</ul>',
    '@if (showMarks) {',
    '    <div>',
    '        @marks ',
    '    </div>',
    '}',
    '',
    '@renderSection("footer")',
    '</body>',
    '</html>'
    ];
    // Solution   
    function solve(args) {
        var nProp = +args[0];
        var i, j, model = {},
            result;

        for (i = 0; i < nProp; i += 1) {
            var lineProp = args[i + 1].split(':');
            var key = lineProp[0],
                value = lineProp[1];

            if (value == 'true') {
                value = true;
            }
            else if (value == 'false') {
                value = false;
            }
            else if (value.indexOf(',') > -1) {
                value = value.split(',');
            }

            model[key] = value;
        }

        var nLine = +args[nProp + 1],
            inShaver = false,
            inSection = false,
            result = [],
            currentSectionContent = [],
            allSection = {},
            nameSection = '';

        for (j = nProp + 2; j < args.length; j += 1) {
            var currentLine = args[j];

            if (inSection && currentLine.indexOf('}' > -1)) {
                inSection = false;
                allSection[nameSection] = currentSectionContent.join('\n');
                
                currentSectionContent = [];
                nameSection = '';
                continue;
            }

            if (inSection) {
                currentSectionContent.push(currentSymbol);
                continue;
            }

            for (var k = 0; k < currentLine.length; k++) {
                var currentSymbol = currentLine[k];

                if (currentSymbol === '@') {
                    if (currentLine[k + 1] === '@') {
                        result.push('@');
                        k += 1;
                        continue;
                    }

                    inShaver = true;
                    continue;
                }

                if (inShaver && (currentSymbol == '}' || currentSymbol == ' ' || currentSymbol == '<')) {
                    inShaver = false;
                }

                if (checkIfInCommant(inShaver, currentLine, 'section')) {
                    nameSection = currentLine.split(' ')[1];
                    inSection = true;
                    inShaver = false;
                    break;
                }
                //else if (checkIfInCommant('if')) {

                //}
                //else if (checkIfInCommant('foreach')){
                    
                //}

                if (!inShaver && !inSection) {
                    result.push(currentSymbol);
                }
            }

            if (!inShaver && !inSection) {
                result.push('\n');
            }
        }

        console.log(result.join(''))
        return result.join('');
        
        function checkIfInCommant(inShaver, currentLine, commantToCheck) {
            return inShaver && currentLine.indexOf('@' + commantToCheck) > -1 && currentLine.indexOf('{') > -1;
        }
    }

    // Output
    WriteLine(solve(test1));
}