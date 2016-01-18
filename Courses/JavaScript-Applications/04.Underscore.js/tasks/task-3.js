/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName`, `age` and `marks` properties
        *   `marks` is an array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (students) {
      var _ = require('../node_modules/underscore/underscore-min.js');
      _.chain(students)
        .map(function (student) {
				student.fullName = student.firstName + ' ' + student.lastName;
                
                var average = 0;
                for (var index = 0; index < student.marks.length; index++) {
                    var studentMark = student.marks[index];
                    average += studentMark;
                }
                
                student.averageMark = average / student.marks.length;
				return student;
			})
		.sortBy('averageMark')
		.last()
		.tap(function (student) {
			console.log(student.fullName + ' has an average score of ' + student.averageMark);
		})
        .value();
  };
}

module.exports = solve;
