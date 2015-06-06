// Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
// Use Array#reduce
// Use only array methods and no regular loops (for, while)
taskName = "Group people";

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
    result = peoples.reduce(GroupByFLetter, {});

    // Solution   
    function Person(fname, lname, age, gender) {
        this.firstName = fname;
        this.lastName = lname;
        this.age = age;
        this.gender = gender;
    }

    function GroupByFLetter(obj, item) {
        debugger;
        if (obj[item.firstName[0]]) {
            obj[item.firstName[0]].push(item);
        }
        else {
            obj[item.firstName[0]] = [item];
        }

        return obj;
    }

// Output
    WriteLine("Result: " + JSON.stringify(result));
}