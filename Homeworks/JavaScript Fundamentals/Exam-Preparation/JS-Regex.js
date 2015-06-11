// www.regexr.com // визуализиране на regex
(/<upcase>(.*?)<\/upcase>/gi) 

var modifier = isCaseSensitive ? "g" : "gi";  // regex

var regex = new RegExp(pattern, modifier);
str.match(regex).length;