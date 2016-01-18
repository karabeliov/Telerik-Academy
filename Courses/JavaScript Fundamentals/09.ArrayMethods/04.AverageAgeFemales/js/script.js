// Write a function that calculates the average age of all females, extracted from an array of persons
// Use Array#filter
// Use only array methods and no regular loops (for, while)
taskName = "Average age of females";

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
    age = averageAge(peoples, 'female') | 0;

    // Solution   
    function Person(fname, lname, age, gender) {
        this.firstName = fname;
        this.lastName = lname;
        this.age = age;
        this.gender = gender;
    }

    function averageAge(peoples, gender) {
        var result = peoples.filter(takeByGender),
            len = result.length,
            i,
            sum = 0;

        for (i = 0; i < len; i++) {
            sum += result[i].age;
        }

        return sum / len;

        function takeByGender(peoples) {
            return peoples.gender === gender;
        }
    }

    // Output
    WriteLine("Average age: " + age);
}