// Write a function that creates a HTML <ul> using a template for every HTML <li>.
// The source of the list should be an array of elements.
// Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
taskName = "Generate list";

function Main(bufferElement) {
    // Input
    var html = '<div data-type="template" id="list-item">' + // Change value to TEST
               '<strong>-{name}-</strong> <span>-{age}-</span>' +
               '/div>',
    people = [
        { name: 'Peter', age: 14 },
        { name: 'Gosho', age: 18 },
        { name: 'Niki', age: 24 },
    ];
    // Solution  
    function generateList(people) {
        var result = '<ul>';
        for (var i = 0; i < people.length; i++) {
            result += '<li>' + '<strong>' + people[i].name + '</strong>' + ' ' +
                                 '<span>' + people[i].age + '</span>' +
                      '</li>';
        }

        result += '</ul>';
        return result;
    }

    function insertHTML(id, html) {
        var el = document.getElementById(id);

        if (!el) {
            alert('Element with id ' + id + ' not found.');
        }

        el.innerHTML = html;
    }
    // Output
    WriteLine("Original HTML: " + html);
    WriteLine();
    WriteLine("Result: " + generateList(people));

    insertHTML("list-item", generateList(people));
}

