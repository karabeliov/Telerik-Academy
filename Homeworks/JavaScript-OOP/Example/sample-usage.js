function solve() {
    var validator,
        Item,
        Book,
        Media,
        Catalog,
        BookCatalog,
        MediaCatalog,
        CONSTANTS = {
            NAME_MIN_LENGTH: 2,
            NAME_MAX_LENGTH: 40,
            ISBN_MIN_LENGTH: 10,
            ISBN_MAX_LENGTH: 13,
            GENRE_MIN_LENGTH: 2,
            GENRE_MAX_LENGTH: 20,
            RATING_MIN_LENGTH: 1,
            RATING_MAX_LENGTH: 5,
        };
    
    Array.prototype.getUnique = function () {
        var u = {}, a = [];
        for (var i = 0, l = this.length; i < l; ++i) {
            if (u.hasOwnProperty(this[i])) {
                continue;
            }
            a.push(this[i]);
            u[this[i]] = 1;
        }
        return a;
    }
    
    function indexOfElementWithIdInCollection(collection, id) {
        var i, len;
        for (i = 0, len = collection.length; i < len; i += 1) {
            if (collection[i].id == id) {
                return i;
            }
        }
        
        return -1;
    }
    
    validator = {
        validateIfUndefined: function (val, name) {
            name = name || 'Value';
            if (val === undefined) {
                throw new Error(name + ' cannot be undefined');
            }
        },
        validateIfObject: function (val, name) {
            name = name || 'Value';
            if (typeof val !== 'object') {
                throw new Error(name + ' must be an object');
            }
        },
        validateIfNumber: function (val, name) {
            name = name || 'Value';
            if (typeof val !== 'number') {
                throw new Error(name + ' must be a number');
            }
        },
        validateEmptyString: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);
            
            if (typeof val !== 'string') {
                throw new Error(name + ' must be a string');
            }
            
            if (val === '') {
                throw new Error(name + ' can be empty string');
            }
        },
        validateString: function (val, min, max, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);
            
            if (typeof val !== 'string') {
                throw new Error(name + ' must be a string');
            }
            
            if (val.length < min 
                    || max <= val.length) {
                throw new Error(name + ' must be between ' + min +
                        ' and ' + max + ' symbols');
            }
        },
        validateISBN: function (val, min, max, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);
            var value = +val;
            if (typeof (value) !== 'number') {
                throw new Error(name + ' must be a number');
            }
            
            if (!(val.length === min || max === val.length)) {
                throw new Error(name + ' must be between ' + min +
                        ' and ' + max + ' symbols');
            }
        },
        validatePositiveNumber: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);
            this.validateIfNumber(val, name);
            
            if (val <= 0) {
                throw new Error(name + ' must be positive number');
            }
        },
        
        validateItems: function (val, name) {
            name = name || 'Value';
            var isValid = true;
            
            if (val === undefined) {
                throw new Error(name + ' cant be undefined');
                isValid = false;
            }
            
            
            if (typeof (val) != 'Item') {
                throw new Error(name + ' is not instans of Item');
                isValid = false;
            }
            
            return isValid;
        },
        validateId: function (id) {
            this.validateIfUndefined(id, 'Object id');
            if (typeof id !== 'number') {
                id = id.id;
            }
            
            this.validateIfUndefined(id, 'Object must have id');
            return id;
        },
        validateBook: function (val, name) {
            name = name || 'Value';
            var isInstance = val.prototype === Book.prototype;
            
            if (val === undefined) {
                throw new Error(name + ' cant be undefined');
            }
            
            if (typeof val !== 'object') {
                throw new Error(name + ' must be an object');
            }
            
            if (!isInstance) {
                throw new Error(name + ' is not instans of Item');
            }
            
        },
    };
    
    Item = (function () {
        var currentItemId = 0,
            Item = Object.create({});
        
        Object.defineProperty(Item, 'init', {
            value: function (description, name) {
                this.description = description;
                this.name = name;
                this._id = ++currentItemId;
                return this;
            }
        });
        
        Object.defineProperty(Item, 'id', {
            get: function () {
                return this._id;
            }
        });
        
        Object.defineProperty(Item, 'description', {
            get: function () {
                return this._description;
            },
            set: function (val) {
                validator.validateEmptyString(val, 'Items description');
                this._description = val;
            }
        });
        
        Object.defineProperty(Item, 'name', {
            get: function () {
                return this._name;
            },
            set: function (val) {
                validator.validateString(val, CONSTANTS.NAME_MIN_LENGTH, CONSTANTS.NAME_MAX_LENGTH, 'Name Length');
                this._name = val;
            }
        });
        
        return Item;
    }());
    
    Book = (function (parent) {
        var book = Object.create(parent);
        
        Object.defineProperty(book, 'init', {
            value: function (name, isbn, genre, description) {
                parent.init.call(this, description, name);
                this.isbn = isbn;
                this.genre = genre;
                return this;
            }
        });
        
        Object.defineProperty(book, 'isbn', {
            get: function () {
                return this._isbn;
            },
            set: function (val) {
                validator.validateISBN(val, CONSTANTS.ISBN_MIN_LENGTH, CONSTANTS.ISBN_MAX_LENGTH, 'ISBN Length');
                this._isbn = val;
            }
        });
        
        Object.defineProperty(book, 'genre', {
            get: function () {
                return this._genre;
            },
            set: function (val) {
                validator.validateString(val, CONSTANTS.GENRE_MIN_LENGTH, CONSTANTS.GENRE_MAX_LENGTH, 'GENRE Length');
                this._genre = val;
            }
        });
        
        return book;
    }(Item));
    
    Media = (function (parent) {
        var media = Object.create(parent);
        
        Object.defineProperty(media, 'init', {
            value: function (name, rating, duration, description) {
                parent.init.call(this, description, name);
                this.rating = rating;
                this.duration = duration;
                return this;
            }
        });
        
        Object.defineProperty(media, 'rating', {
            get: function () {
                return this._rating;
            },
            set: function (val) {
                validator.validateString(val, CONSTANTS.RATING_MIN_LENGTH, CONSTANTS.RATING_MAX_LENGTH, 'rating Length');
                this._rating = val;
            }
        });
        
        Object.defineProperty(media, 'duration', {
            get: function () {
                return this._duration;
            },
            set: function (val) {
                validator.validatePositiveNumber(val, 'duration Length');
                this._duration = val;
            }
        });
        
        return media;
    }(Item));
    
    Catalog = (function () {
        var currentCatalogId = 0,
            Catalog = Object.create({});
        
        Object.defineProperty(Catalog, 'init', {
            value: function (name) {
                this.name = name;
                this._items = [];
                this._id = ++currentCatalogId;
                return this;
            }
        });
        
        Object.defineProperty(Catalog, 'id', {
            get: function () {
                return this._id;
            }
        });
        
        Object.defineProperty(Catalog, 'name', {
            get: function () {
                return this._name;
            },
            set: function (val) {
                validator.validateString(val, CONSTANTS.NAME_MIN_LENGTH, CONSTANTS.NAME_MAX_LENGTH, 'Catalog Name Length');
                this._name = val;
            }
        });
        
        Object.defineProperty(Catalog, 'items', {
            get: function () {
                return this._items;
            }
        });
        
        Object.defineProperty(Catalog, 'add', {
            value: function (item) {
                validator.validateItems(item, 'Add Item');
                validator.validateBook(item, 'Book')
                
                return this;
            }
        });
        
        Object.defineProperty(Catalog, 'find', {
            value: function (id) {
                var i, len;
                validator.validateIfUndefined(id, 'Player get playlist parameter id');
                validator.validateIfNumber(id, 'Player get playlist paratemeter id');
                
                var foundIndex = indexOfElementWithIdInCollection(this._items, id);
                if (foundIndex < 0) {
                    return null;
                }
                
                return this._items[foundIndex];
            }
        });
        
        Object.defineProperty(Catalog, 'search', {
 // TODO 
            value: function (pattern) {
                if (pattern.length < 1) {
                    throw new Error(pattern + ' have short pattern');
                }
                
                return [];
            }
        });
        return Catalog;
    }());
    
    BookCatalog = (function (parent) {
        var BookCatalog = Object.create(parent);
        
        Object.defineProperty(BookCatalog, 'init', {
            value: function (name) {
                parent.init.call(this, name);
                return this;
            }
        });
        
        Object.defineProperty(BookCatalog, 'getGenres', {
            value: function () {
                
                return [];
            }
        });
        
        return BookCatalog;
    }(Catalog));
    
    MediaCatalog = (function (parent) { // TODO
        var MediaCatalog = Object.create(parent);
        
        Object.defineProperty(MediaCatalog, 'init', {
            value: function (name) {
                parent.init.call(this, name);
                return this;
            }
        });
        
        Object.defineProperty(MediaCatalog, 'getTop', {
            value: function (count) {
                validator.validateIfNumber(count);
                if (count < 1) {
                    throw new Error(pattern + ' have short pattern');
                }
                
                return [];
            }
        });
        
        Object.defineProperty(MediaCatalog, 'getSortedByDuration', {
            value: function () {
                return [];
            }
        });
        
        return MediaCatalog;
    }(Catalog));
    
    return {
        getBook: function (name, isbn, genre, description) {
            return Object.create(Book).init(name, isbn, genre, description);
        },
        getMedia: function (name, rating, duration, description) {
            return Object.create(Media).init(name, rating, duration, description);
        },
        getBookCatalog: function (name) {
            return Object.create(BookCatalog).init(name);
        },
        getMediaCatalog: function (name) {
            return Object.create(MediaCatalog).init(name);
        }
    };
}