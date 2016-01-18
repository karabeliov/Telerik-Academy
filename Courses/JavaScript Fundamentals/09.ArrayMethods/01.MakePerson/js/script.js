// Write a function for creating persons.
// Each person must have firstname, lastname, age and gender (true is female, false is male)
// Generate an array with ten person with different names, ages and genders
taskName = "Make person";

function Main(bufferElement) {
    // Input
    var peoples = [  // Change value to TEST
        new Person('Bob', 'Fild', 31, 'male'),
        new Person('James', 'Tomkins', 15, 'male'),
        new Person('Helen', 'Owen', 17, 'female'),
        new Person('Kevin', 'Nolan', 32, 'male'),
        new Person('Audrey', 'Tautou', 39, 'female'),
        new Person('Jerard', 'Pique', 21, 'male'),
        new Person('Penelope', 'Cruz', 41, 'female'),
        new Person('Jean', 'Dujardin', 42, 'male'),
        new Person('Keira', 'Knightley', 29, 'female')
    ]; 
    // Solution   
    function Person(fname, lname, age, gender) {
        this.firstName = fname;
        this.lastName = lname;
        this.age = age;
        this.gender = gender;
    }

    function creatingPerson(item) {
        return WriteLine(JSON.stringify(item));
    }
    // Output
    peoples.forEach(creatingPerson);
}