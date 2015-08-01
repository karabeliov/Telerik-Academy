  function instructions() {
    var stageWidth = 800,
    stageHeight = 600,
    stage = new Kinetic.Stage({
    container: 'paper',
    width: stageWidth,
    height: stageHeight,
  });
  
  var paper = document.getElementById('paper');
  var goodLuck = document.getElementById('goodLuck');
  var layer = new Kinetic.Layer();
  
  var rect = new Kinetic.Rect({
      x: 50,
      y: 70,
      opacity: 0.8,
	  cornerRadius: 15,
      width: 700, 
      height: 500, 
      fill: 'white', 
  });

 var text = new Kinetic.Text({
      x: 310,
      y: 100,
      fontFamily: 'Verdana',
      fontSize: 30,
      text: 'Инструкции',
      fill: 'black',
      stroke: 'black'
  });
 
  var line1 = new Kinetic.Text({
      x: 100,
      y: 160,
      fontFamily: 'Verdana',
      fontSize: 18,
      text: 'Целта на играта е да преведете всички на отсрещният бряг.',
      fill: 'black',
      stroke: 'black'
  });
  
  var line2 = new Kinetic.Text({
      x: 100,
      y: 190,
      fontFamily: 'Verdana',
      fontSize: 18,
      text: 'Като трябва да спазите следните условия:',
      fill: 'black',
      stroke: 'black'
  });
  
   var line3 = new Kinetic.Text({
      x: 120,
      y: 230,
      fontFamily: 'Verdana',
      fontSize: 18,
      text: '- Не повече от двама пътници на сала.',
      fill: 'black',
      stroke: 'black'
  });
  
   var line4 = new Kinetic.Text({
      x: 120,
      y: 260,
      fontFamily: 'Verdana',
      fontSize: 18,
      text: '- Само майката, бащата и полицая могат да управляват сала.',
      fill: 'black',
      stroke: 'black'
  });
  
   var line5 = new Kinetic.Text({
      x: 120,
      y: 290,
      fontFamily: 'Verdana',
      fontSize: 18,
      text: '- Майката не може да остава със синовете без бащата.',
      fill: 'black',
      stroke: 'black'
  });
  
  var line6 = new Kinetic.Text({
      x: 120,
      y: 320,
      fontFamily: 'Verdana',
      fontSize: 18,
      text: '- Бащата не може да остава с дъщерите без майката.',
      fill: 'black',
      stroke: 'black'
  });
  
   var line7 = new Kinetic.Text({
      x: 120,
      y: 350,
      fontFamily: 'Verdana',
      fontSize: 18,
      text: '- Затворника не може да остава с никого без полицая.',
      fill: 'black',
      stroke: 'black'
  });
  
  var line8 = new Kinetic.Text({
      x: 120,
      y: 380,
      fontFamily: 'Verdana',
      fontSize: 18,
      text: '- Имате 10 минути, за да го направите.',
      fill: 'black',
      stroke: 'black'
  });
		
      layer.add(rect);
      layer.add(text);
      layer.add(line1);
      layer.add(line2);
      layer.add(line3);
      layer.add(line4);
      layer.add(line5);
      layer.add(line6);
      layer.add(line7);
      layer.add(line8);
      stage.add(layer);
  }
  
  function visibility() {
    if (paper.style.visibility == 'visible') {
      paper.style.visibility='hidden';
      goodLuck.style.visibility='hidden';
    }
    else {
      paper.style.visibility='visible';
      goodLuck.style.visibility='visible';
    }
  }