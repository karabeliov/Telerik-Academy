// Write a function that finds the youngest male person in a given array of people and prints his full name
// Use only array methods and no regular loops (for, while)
// Use Array#find
taskName = "Youngest person";

function Main(bufferElement) {
// Input
    var peoples = [  // Change value to TEST
        new Person('Bob', 'Fild', 5, 'male'),
        new Person('James', 'Tomkins', 15, 'male'),
        new Person('Helen', 'Owen', 12, 'female'),
        new Person('Kevin', 'Nolan', 32, 'male'),
        new Person('Audrey', 'Tautou', 39, 'female'),
        new Person('Jerard', 'Pique', 21, 'male'),
        new Person('Penelope', 'Cruz', 11, 'female'),
        new Person('Jean', 'Dujardin', 42, 'male'),
        new Person('Keira', 'Knightley', 29, 'female')
    ],
    youngest = findPerson(peoples, 'male');
    // Solution   
    function Person(fname, lname, age, gender) {
        this.firstName = fname;
        this.lastName = lname;
        this.age = age;
        this.gender = gender;
    }

    function findPerson(peoples, gender) {
        debugger;
        var result = peoples.filter(byGender),
            i,
            len = result.length,
            youngestPerson = +Infinity;
       
        function byGender(peoples) {
            return peoples.gender === gender;
        }

        for (i = 0; i < len; i++) {
            if (peoples[i].age < youngestPerson) {
                youngestPerson = peoples[i];
            }
        }

        return JSON.stringify(youngestPerson);
    }
// Output
    WriteLine("Yongest: " + youngest);
}