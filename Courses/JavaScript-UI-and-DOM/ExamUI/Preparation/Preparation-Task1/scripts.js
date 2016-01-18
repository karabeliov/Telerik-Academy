function createImagesPreviewer(selector, items) {
    // TODO validate input
    var container = document.querySelector(selector);
    var fragment = document.createDocumentFragment();

    var imagePreview = document.createElement('div');
    imagePreview.style.display = 'inline-block';
    imagePreview.style.textAlign = 'center';
    imagePreview.style.float = 'left';
    imagePreview.style.width = '80%';

    var header = document.createElement('h1');
    header.innerText = items[0].title;
    imagePreview.appendChild(header);

    var selectedImage = document.createElement('img');
    selectedImage.src = items[0].url;
    selectedImage.style.width = '70%';
    imagePreview.appendChild(selectedImage);

    var aside = document.createElement('div');
    aside.style.display = 'inline-block';
    aside.style.textAlign = 'center'
    aside.style.float = 'left';
    aside.style.width = '20%';
    
    var input = document.createElement('input');
    var filterHead = document.createElement('h3');

    input.addEventListener('keyup', function (ev) {
        var text = ev.target.value;
        var liChildren = ul.getElementsByTagName('li');
        
        for (var i = 0, len = liChildren.length; i < len; i+=1) {
            var currLi = liChildren[i];
            var childHeadText = currLi.firstElementChild.innerText;
            if (childHeadText.toLowerCase().indexOf(text.toLowerCase()) >= 0) {
                currLi.style.display = 'block';
            } else {
                currLi.style.display = 'none';
            }
        }

    }, false)

    filterHead.innerText = 'Filter';
    aside.appendChild(filterHead);
    aside.appendChild(input);

    var ul = document.createElement('ul');
    ul.style.listStyleType = 'none';
    ul.style.height = '500px';
    ul.style.overflowY = 'scroll';

    var li = document.createElement('li');
    var headerLI = document.createElement('h5');

    for (var i = 0, len = items.length; i < len; i += 1) {
        var currentTitle = items[i].title;
        var currentImage = items[i].url;

        var currentLI = li.cloneNode(true);
        currentLI.classList.add('image-container');
        var currentHeaderLI = headerLI.cloneNode(true);
        currentHeaderLI.innerText = currentTitle;
        var currentImageLI = document.createElement('img');
        currentImageLI.style.width = '100%';
        currentImageLI.src = currentImage;

        currentLI.appendChild(currentHeaderLI);
        currentLI.appendChild(currentImageLI);
        ul.appendChild(currentLI);
    }

    ul.addEventListener('click', function (ev) {
        var target = ev.target;

        if (target.tagName === 'IMG') {
            header.innerText = target.previousElementSibling.innerText;
            selectedImage.src = target.src;
        }
    }, false);

    ul.addEventListener('mouseover', function (ev) {
        var target = ev.target;
        if (target.tagName === 'IMG') {
            var parent = target.parentNode;
            parent.style.backgroundColor = 'gray';
            parent.style.cursor = 'pointer';
        }
    }, false);

    ul.addEventListener('mouseout', function (ev) {
        var target = ev.target;
        if (target.tagName === 'IMG') {
            var parent = target.parentNode;
            parent.style.backgroundColor = '';
            parent.style.cursor = '';
        }
    }, false);

    aside.appendChild(ul);

    fragment.appendChild(imagePreview);
    fragment.appendChild(aside);

    container.appendChild(fragment);
}