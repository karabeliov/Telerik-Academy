// Write a function that finds the youngest person in a given array of people and prints his/hers full name
// Each person has properties firstname, lastname and age.
taskName = "Youngest person";

function Main(bufferElement) {
// Input
    var people = [
    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },  // Change value to TEST
    { firstname: 'Ivo', lastname: 'Hristov', age: 12 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 }];
// Solution   
    function youngest(people) {
        var person, 
            age = 150;
        for (var i = 0; i < people.length; i++) {
            if (people[i].age < age) {
                age = people[i].age;
                person = people[i];
            }
        }

        return person;
    }

    var youngestPerson = youngest(people).firstname + " " + youngest(people).lastname;
// Output
    WriteLine("Youngest person: " + youngestPerson);
}