/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	var Person = (function () {
		function Person(firstname, lastname, age) {
			this.firstname = firstname;
			this.lastname = lastname;
			this.age = age;
		}
		
			Object.defineProperty(Person.prototype, 'firstname', {
				get: function() {
					return this._firstname;
				},
				set: function(newName) {
					if (newName.length < 3 || newName.length > 20) {
						throw "Invalid First Name";
					}
					
					this._firstname = newName;
					
					return this;
				}
			});
			
			Object.defineProperty(Person.prototype, 'lastname', {
				get: function() {
					return this._lastname;
				},
				set: function(newLname) {
					if (newLname.length < 3 || newLname.length > 20) {
						throw "Invalid First Name";
					}
					
					this._lastname = newLname;
					
					return this;
				}
			});
			
			Object.defineProperty(Person.prototype, 'age', {
				get: function() {
					return this._age;
				},
				set: function(newAge) {
					if (+newAge <= 0 || +newAge >= 150) {
						throw "Invalid Last Name";
					}
					
					this._age = newAge;
					
					return this;
				}
			});
			
			Object.defineProperty(Person.prototype, 'fullname', {
				get: function() {
					return this.firstname + ' ' + this.lastname;
				},
				set: function(newFullName) {
					var name = newFullName.split(' ');;
					
					if (name[0].length < 3 || name[0].length > 20) {
						throw "Invalid First Name";
					}
					
					if (name[1].length < 3 || name[1].length > 20) {
						throw "Invalid First Name";
					}
					
					this.firstname =  name[0];
					this.lastname = name[1];
					
					this._fullname = this.firstname + ' ' + this.lastname;
					
					return this;
				}
			});
			
			Object.defineProperty(Person.prototype, 'introduce', {
				get: function() {
					return function() {
					return 'Hello! My name is ' + this.firstname + ' ' + this.lastname +
						' and I am ' + this.age + '-years-old';
					};
				}
			});
			
		return Person;
	} ());
	return Person;
}

module.exports = solve;