export default {
    string: function (str)
    {
      return new Promise(function(resolve, reject) {
          if (typeof(str) === 'string') {
              resolve('OK');
          } else {
              reject('This is not a string');
          }
      });
     },
    lenght: function (text, min, max){
        return new Promise(function(resolve, reject) {
            if (text.length >= min && text.length <= max) {
                resolve('OK');
            } else {
                reject('Text too long or small');
            }
        });
    },
	 characters: function (str)
   {
     return new Promise(function(resolve, reject) {
       var patern = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])\w{6,}$/;
         if (patern.test(str)) {
             resolve('OK');
         } else {
             reject('Can contain only Latin letters, digits and the characters underscore or dot;');
         }
     });
    }
}
