// Write a function that prints all underaged persons of an array of person
// Use Array#filter and Array#forEach
// Use only array methods and no regular loops (for, while)
taskName = "Underage people";

function Main(bufferElement) {
// Input
    var peoples = [  // Change value to TEST
        new Person('Bob', 'Fild', 31, 'male'),
        new Person('James', 'Tomkins', 15, 'male'),
        new Person('Helen', 'Owen', 12, 'female'),
        new Person('Kevin', 'Nolan', 32, 'male'),
        new Person('Audrey', 'Tautou', 39, 'female'),
        new Person('Jerard', 'Pique', 21, 'male'),
        new Person('Penelope', 'Cruz', 11, 'female'),
        new Person('Jean', 'Dujardin', 42, 'male'),
        new Person('Keira', 'Knightley', 29, 'female')
    ],
    underaged = peoples.filter(isUnderaged);

// Solution   
    function isUnderaged(item) {
        return item.age < 18;
    }

    function Person(fname, lname, age, gender) {
        this.firstName = fname;
        this.lastName = lname;
        this.age = age;
        this.gender = gender;
    }

    function creatingPerson(item) {
        return JSON.stringify(item);
    }

    // Output
    WriteLine("Underaged People: ");
    WriteLine(creatingPerson(underaged));
}