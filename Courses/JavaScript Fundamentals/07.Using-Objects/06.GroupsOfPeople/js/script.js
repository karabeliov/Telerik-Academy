// Write a function that groups an array of people by age, first or last name.
// The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
// Use function overloading (i.e. just one function)
taskName = "Groups of people";

function Main(bufferElement) {
    // Input
    var people = [
        { firstname: 'Gosho', lastname: 'Petrov', age: 32 },  // Change value to TEST
        { firstname: 'Ivo', lastname: 'Hristov', age: 12 },
        { firstname: 'Bay', lastname: 'Ivan', age: 81 }],
        groupedByFname = group(people, 'firstname'),
        groupedByLname = group(people, 'lastname'),
        groupedByAge = group(people, 'age');
    // Solution   
    function group(people, key) {
        groupOfPeople = [];
        if (key.charAt(0) === 'f') {
            for (var i = 0; i < people.length; i++) {
                groupOfPeople.push(people[i].firstname)
            }
        }
        else if (key.charAt(0) === 'l') {
            for (var i = 0; i < people.length; i++) {
                groupOfPeople.push(people[i].lastname)
            }
        }
        else if (key.charAt(0) === 'a') {
            for (var i = 0; i < people.length; i++) {
                groupOfPeople.push(people[i].age)
            }
        }
        else {
            groupOfPeople = people;
        }

        return groupOfPeople;
    }
    // Output
    WriteLine("People grouped by first name: " + groupedByFname);
    WriteLine("People grouped by last name: " + groupedByLname);
    WriteLine("People grouped by age: " + groupedByAge);
}