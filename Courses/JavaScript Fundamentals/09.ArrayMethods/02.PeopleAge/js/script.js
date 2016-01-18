// Write a function that checks if an array of person contains only people of age (with age 18 or greater)
// Use only array methods and no regular loops (for, while)
taskName = "People of age";

function Main(bufferElement) {
    // Input
    var peoples = [  // Change value to TEST
        new Person('Bob', 'Fild', 31, 'male'),
        new Person('James', 'Tomkins', 15, 'male'),
        new Person('Helen', 'Owen', 18, 'female'),
        new Person('Kevin', 'Nolan', 32, 'male'),
        new Person('Audrey', 'Tautou', 39, 'female'),
        new Person('Jerard', 'Pique', 21, 'male'),
        new Person('Penelope', 'Cruz', 41, 'female'),
        new Person('Jean', 'Dujardin', 42, 'male'),
        new Person('Keira', 'Knightley', 29, 'female')
    ],
    isAdult = peoples.some(checkAdults);

    // Solution   
    function Person(fname, lname, age, gender) {
        this.firstName = fname;
        this.lastName = lname;
        this.age = age;
        this.gender = gender;
    }

    function checkAdults(item) {
        return item.age >= 18;
    }

    // Output
    Write("Is there adults in the group of people: ");
    WriteLine(isAdult ? "Yes" : "No");
}