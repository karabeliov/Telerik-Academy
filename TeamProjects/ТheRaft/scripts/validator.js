var Validator = (function(){
	'use strict';
	
	function That (c) {
		if(!Array.isArray(c)) {
			c = c.seated;
		}
		return {
			has: function() {
				var args = [].slice.call(arguments);
				var len = args.length, contained = 0;
				if (len === 0) {
					return false;
				}
				for (var i = 0; i < len; i++) {
					if (c.some(function(el){
						return (el.role === args[i]);
					})) {
						contained++;
					}
				}
				if (contained === len) {
					return true;
				}
				return false;
			},
			hasNo: function() {
				var args = [].slice.call(arguments);
				var len = args.length, contained = 0;
				if (len === 0) {
					return false;
				}
				for (var i = 0; i < len; i++) {
					if (c.some(function(el){
						return (el.role === args[i]);
					})) {
						contained++;
					}
				}
				if (contained = len) {
					return true;
				}
				return false;
			}
		};
	}
	
	function Validator(c, r, a) {
		this.characters = c;
		this.raft = r;
		this.arrow = a;
	}
	Validator.prototype.validateMove = function () {
		var side, chars;
		
		var boy = false, girl = false, father = false, mother = false, policeman = false, criminal = false;
		//Check if the raft can travel
		boy = That(this.raft).has('boy');
		girl = That(this.raft).has('girl');
		father = That(this.raft).has('father');
		mother = That(this.raft).has('mother');
		policeman = That(this.raft).has('policeman');
		criminal = That(this.raft).has('criminal');
		
		if (this.raft.seated.length === 0) {
			return {canTravel: false, messege: 'Сала е празен.'};
		}
		if (this.raft.seated.length === 1 && criminal) {
			return {canTravel: false, messege: 'Затворника не може да пътува сам.'};
		}
		if (criminal && !policeman) {
			return {canTravel: false, messege: 'Затворника не може да пътува без полицая.'};
		}
		if ((boy || girl) && !(mother || father || policeman)) {
			return {canTravel: false, messege: 'Децата не могат да пътуват сами.'};
		}
		if (boy && mother) {
			return {canTravel: false, messege: 'Майката не може да пътува със синовете.'};
		}
		if (girl && father) {
			return {canTravel: false, messege: 'Бащата не може да пътува с дъщерите.'};
		}
		
		var policemanOnRaft = policeman;
		
		//Check the opposite side
		if (this.raft.side === 'left') {
			side = 'right';
		} else {
			side = 'left'
		}
		chars = [];
		for (var i = 0, len = this.characters.length; i < len; i++) {
			if (this.characters[i].side === side) {
				chars.push(this.characters[i]);
			}
		}
		if (!policemanOnRaft && That(chars).has('criminal') && !That(chars).has('policeman')) {
			return {canTravel: false, messege: 'Затворника може да убие всички.'};
		}
		if (mother && !father && That(chars).has('boy') && !That(chars).has('father')) {
			return {canTravel: false, messege: 'Майката може да набие синовете.'};
		}
		if (father && !mother && That(chars).has('girl') && !That(chars).has('mother')) {
			return {canTravel: false, messege: 'Бащата може да набие дъщерите.'};
		}
		
		//Check is the side the raft is on is valid
		side = this.raft.side;
		chars = [];
		for (var i = 0, len = this.characters.length; i < len; i++) {
			if (this.characters[i].side === side) {
				chars.push(this.characters[i]);
			}
		}
		
		boy = That(chars).has('boy');
		girl = That(chars).has('girl');
		father = That(chars).has('father');
		mother = That(chars).has('mother');
		policeman = That(chars).has('policeman');
		criminal = That(chars).has('criminal');
		
		if (chars.length > 1 && criminal && !policeman) {
			return {canTravel: false, messege: 'Затворника може да убие всички.'};
		}
		if (boy && mother && !father) {
			return {canTravel: false, messege: 'Майката може да набие синовете.'};
		}
		if (girl && father && !mother) {
			return {canTravel: false, messege: 'Бащата може да набие дъщерите.'};
		}
		//Finally:
		return {canTravel: true, messege: 'Няма конфликти.'};
	};
	
	Validator.prototype.travel = function() {
		var dx, x;
		if (this.raft.side === 'left') {
			dx = 220;
		} else {
			dx = -220;
		}
		for (var i = 0, len = this.raft.seated.length; i < len; i++) {
			x = this.raft.seated[i].player.getX();
			this.raft.seated[i].animation = new Kinetic.Tween({
				node: this.raft.seated[i].player,
				x: x + dx,
				duration: 0.69
			});
			this.raft.seated[i].animation.play();
		}
	};
	
	return Validator;
})();