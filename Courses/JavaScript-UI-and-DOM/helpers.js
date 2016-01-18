//UI & DOM function helpers
'use strict';

var el = document.createElement(tagName); //to created an element
document.appendChild(element); //to append an element to another element, in this case - the document

//Working with element attributes
	el.hasAttribute(name);
	el.getAttribute(name);
	el.setAttribute(name, value);
	el.removeAttribute(name);

//Removing element
	var parent = el.parentNode;
	// var parent = el.parentElement;
	parent.removeChild(el);

//Working with the class(es) of an element
	el.className = 'concatenated classes';

//Inserting childred at positions
	el.insertBefore(newChild, refChild);

//Cloning an element (for faster dom insertions)
	var newEl = el.cloneNode(true);

//Working with children
	var children = el.children;
	var elementChildrenCount = el.childElementCount;
	var firstChild = el.firstElementChild;
	var lastChild = el.lastElementChild;

//Element positioning
	var nextElement = el.nextElementSibling;
	var prevElement = el.previousElementSibling;

//Type of element
	var tagName = el.tagName; //tagName will be in CAPS

//For fast dom insertion
	var fragment = document.createDocumentFragment();
	//Adding children and content fo fragment, then:
	el.appendChild(fragment);


////////////////////////////////////////////////////////////
//                 E V E N T S                            //
////////////////////////////////////////////////////////////

//UI Events:
var uiEvents = [
	load,
	unload,
	error,
	resize,
	scroll
];

//Keyboard Events
var keyboardEvents = [
	keydown,
	keyup,
	keypress
];

//Mouse Events
var mouseEvents = [
	click,
	dblclick,
	mousedown,
	mouseup,
	mousemove,
	mouseover,
	mouseout
];

//Focus Events
var focusEvents = [
	focus,
	blur
];

//Form Event
var formEvents = [
	input, //Value in <input> or <textarea> has changed or any element with the "contenteditable" attribute ( IE9+ )
	change, //Value in select box, checkbox or radiobutton changes ( IE9+ )
	submit, //User submits a form
	cut, //User cuts content from a form field
	copy, //User copies content
	paste, //User pastes content
	select //User selects text from a form field
];