/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example
var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');
var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)
var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');
div.content = 'Hello, world!';
var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');
var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);
console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
	var domElement = (function () {
		function checkIsString(name) {
			if (typeof name != 'string' || name == '') {
				throw new Error();
			}
		};
		
		function checkValid(name) {
			var index, len;
			for (index = 0, len = name.length; index < len; index += 1) {
				var element = name[index];
				
				if (!isNaN(element) || element == '!') {
					throw new Error();
				}
			}
		};
		
		var domElement = {
			init: function(type) {
				checkIsString(type);
				checkValid(type);
				
				this.type = type;
				this.childs = [];
				this.attributes = {};
				this.content = '';
				
				return this;
			},
			appendChild: function(child) {
				checkIsString(child);
				checkValid(child);
				
				this.childs.push(child);
				
				return this;
			},
			addAttribute: function(name, value) {
				checkIsString(name);
				checkValid(name);
				
				this.attributes[name] = value;
				
				return this;
			},
			removeAttribute: function (name) {
				if (this.attributes[name] != undefined) {
					delete this.attributes[name];
				} else {
					throw new Error();
				}
				
				return this;
			},	
	       get innerHTML(){
			   return createInnerHtml(this);
	       }
		};
		
		function createInnerHtml(obj) {
            var innerResult = '',
                result;
            if (obj.childs.length > 0) {
                obj.childs.forEach(function(item) {
                    typeof item === 'string' ? innerResult += item : innerResult += item.innerHTML;
                });
                result = '<' + obj.type + ' ' + parseAttributes(obj.attributes) + '>' + innerResult + '</' + obj.type + '>';
            } else {
                result = '<' + obj.type + ' ' + parseAttributes(obj.attributes) + '>' + obj.content + '</' + obj.type + '>';
            }

            return result;
        }

        function parseAttributes(obj) {
            var result = ' ',
                attr,
                arr = [];
            for (attr in obj) {
                arr.push([attr, obj[attr]]);
            }
            arr.sort();
            arr.forEach(function(item) {
                result += item[0] + '="' + item[1] + '" ';
            });
            return result.trim();
        }

        Object.defineProperty(domElement, 'type', {
            get: function() {
                return this._type;
            },
            set: function(value) {
                if (value === '' || value.match(/[^\w]/)) {
                    throw 'Letters and digits only';
                }

                this._type = value;
            },
            enumerable: true
        });

        Object.defineProperty(domElement, 'content', {
            get: function() {
                return this._content;
            },
            set: function(value) {
                if (!this.hasChildren) {
                    this._content = value;
                }
            },
            enumerable: true
        });
		
		return domElement;
	} ());
	return domElement;
}

module.exports = solve;