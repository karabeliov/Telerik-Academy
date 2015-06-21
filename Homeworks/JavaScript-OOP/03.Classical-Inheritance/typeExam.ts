enum Towns { 
		Sofia,
		Plovdiv,
		Varna,
		Burgas
	}

interface IPerson {
	firstName: string;
	lastName: string;
	age?: number;
}

interface IStudent {
	id: number;
	course: string[];
	homeTown: Towns;
}



class Person implements IPerson {
	firstName = this.firstName;
	lastName = this.lastName;
	
	constructor(fName: string, lName: string) {
		this.firstName = fName;
		this.lastName = lName;
	}	
}

class Student extends Person implements IStudent, IPerson {
	id = this.id;
	course = this.course;	
	homeTown = this.homeTown;
	
	constructor(fName: string, lName: string, id: number, course: string[], homeTown: Towns) {
		super(fName, lName);
		this.id = id;
		this.course = course;
		this.homeTown = homeTown;
	}
}

var Kris = new Student('Kristian', 'Karabeliov', 26, ['JavaScript', 'JavaScript-OOP'], Towns.Sofia);

console.log(Kris);
console.log(JSON.stringify(Kris));



