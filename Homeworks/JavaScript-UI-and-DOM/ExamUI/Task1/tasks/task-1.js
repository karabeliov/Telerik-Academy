function solve() {
  return function (selector, isCaseSensitive) {
    var root = document.querySelector(selector);
    root.className += 'items-control';
    var resultList = document.createElement('ul');
    resultList.className += 'items-list';
    var fragment = document.createDocumentFragment();
    // Input
    var inputField = document.createElement('div');
    inputField.className += 'add-controls';
    var inputLabel = document.createElement('label');
    inputLabel.innerHTML = 'Enter text';
    inputField.appendChild(inputLabel);
    var inputText = document.createElement('input');
    inputField.appendChild(inputText);
    
    
    var buttonAdd = document.createElement('button');
    buttonAdd.className += 'button';
    buttonAdd.innerHTML += 'Add';
    inputField.appendChild(buttonAdd);
    
    buttonAdd.addEventListener('click', function (ev) {
      var textItem = inputText.value;
      var li = document.createElement('li');
      var buttonX = document.createElement('button');
      buttonX.className += 'button';
      buttonX.innerHTML += 'X';
      li.className += 'list-item';
	  li.appendChild(buttonX);
      li.innerHTML = '<b>' + textItem + '</b>';
      
      if (textItem !== '') {
         li.appendChild(buttonX);
         resultList.appendChild(li);
      }
    }, false);
    
    resultList.addEventListener('click', function (ev) {
      var target = ev.target;
      if (target.className == 'button') {
        var parent = target.parentElement;
        resultList.removeChild(parent);
      }
    });
    
    
    // Search
    var searchField = document.createElement('div');
    searchField.className += 'search-controls';
    var searchLabel = document.createElement('label');
    searchLabel.innerHTML = 'Search:';
    searchField.appendChild(searchLabel);
    var inputSearch = document.createElement('input');
    searchField.appendChild(inputSearch);
    
    // Search Functionality
	inputSearch.addEventListener('input', function() {
            var currentValue = inputSearch.value;
            var elements = document.getElementsByClassName('list-item');
            for (var i = 0; i < elements.length; i++) {
                var currentHTML = elements[i].innerHTML;
                var secondHTML = "";
                if (currentHTML != undefined) {
                    for (var q = 0; true; q += 1) {
                        if (currentHTML[q] == '<') {
                            break;
                        }
                        secondHTML += currentHTML[q];
                    }
                }
                if (!isCaseSensitive) {
                    currentValue = currentValue.toLowerCase();
                    secondHTML = secondHTML.toLowerCase();
                }
 
                if (!(secondHTML.indexOf(currentValue) > -1)) {
                    elements[i].style.display = 'none';
 
                } else {
                    elements[i].style.display = 'block';
                }
            }
        })
    
    // Result
    var resultField = document.createElement('div');
    resultField.className += 'result-controls';
    resultField.appendChild(resultList);
   
    
    // Finnaly
    fragment.appendChild(inputField);
    fragment.appendChild(searchField);  
    fragment.appendChild(resultField);
    
    root.appendChild(fragment);
  };
}