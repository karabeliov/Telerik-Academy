function solve() {
  return function () {
    /* globals $ */
    $.fn.gallery = function (count) {
		 count = count || 4;
    var gallery = this;
    gallery.addClass('gallery');
    var galleryList = gallery.children('.gallery-list');
    var selected = gallery.children('.selected');
    var imageContainers = galleryList.children('.image-container');
    var previousImage = selected.find('#previous-image')
    var currentImage = selected.find('#current-image');
    var nextImage = selected.find('#next-image');
    
    selected.hide();

    imageContainers.each(function (index, item) {
        item = $(item);
        if (index % count == 0) {
            item.addClass('clearfix');
        }
    });

    galleryList.on('click', 'img', function () {
        var $this = $(this);
        galleryList.addClass('blurred');
        $('<div />').addClass('disabled-background').appendTo(galleryList);
        applySelected($this);

        selected.show();
    });

    currentImage.on('click', function () {
        galleryList.removeClass('blurred');
        selected.hide();
        galleryList.children('.disabled-background').remove();
    });

    previousImage.on('click', function () {
        var $this = $(this);
        applySelected($this);
    });

    nextImage.on('click', function () {
        var $this = $(this);
        applySelected($this);
    });

    function setImageInformation($element, src, index) {
        $element.attr('src', src);
        $element.attr('data-info', index);
    }

    function getImageByIndex(index) {
        return gallery.find('img[data-info="' + index + '"]');
    }

    function getElementInfo($element) {
        return {
            src: $element.attr('src'),
            index: parseInt($element.attr('data-info'))
        }
    }

    function getNextIndex(index) {
        index++;
        if (index > imageContainers.length) {
            index = 1;
        }

        return index;
    }

    function getPreviousIndex(index) {
        index--;
        if (index < 1) {
            index = imageContainers.length;
        }

        return index;
    }

    function applySelected($element) {
        var currentImageInfo = getElementInfo($element);
        setImageInformation(currentImage, currentImageInfo.src, currentImageInfo.index);

        var previousIndex = getPreviousIndex(currentImageInfo.index);
        var nextIndex = getNextIndex(currentImageInfo.index);

        var previous = getImageByIndex(previousIndex);
        var next = getImageByIndex(nextIndex);

        var previousImageInfo = getElementInfo(previous);
        var nextImageInfo = getElementInfo(next);

        setImageInformation(previousImage, previousImageInfo.src, previousImageInfo.index);
        setImageInformation(nextImage, nextImageInfo.src, nextImageInfo.index);
    }
    return this;
    };
  };
}

module.exports = solve;