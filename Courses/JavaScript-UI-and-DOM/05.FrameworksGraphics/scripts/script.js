  var stageWidth = 800,
    stageHeight = 600,
    stage = new Kinetic.Stage({
    container: 'container',
    //width: document.body.clientWidth
    width: stageWidth,
    height: stageHeight
  });

  var layer = new Kinetic.Layer();
  
  var familyMembers = [{
    mother: 'Maria Petrova',
    father: 'Georgi Petrov',
    children: ['Teodora Petrova', 'Peter Petrov']
  }, {
    mother: 'Petra Stamatova',
    father: 'Todor Stamatov',
    children: ['Maria Petrova']
  }] ;
  
  // TODOR
  var todor = new Kinetic.Rect({
    x: 150,
    y: 50,
    width: 190, 
    height: 70,
    strokeWidth: 3,
    stroke: 'yellowgreen',
    fill: 'skyblue',
    cornerRadius: 10
  });
  
  var todorText = new Kinetic.Text({
      x: 164,
      y: 68,
      text: familyMembers[1].father,
      fontSize: 25,
      fontFamily: 'Calibri',
      stroke: 'black',
      fill: 'black',
  });
  
  var todorLine = new Kinetic.Line({
    points: [240, 120, 280, 170, 370, 180, 400, 200],
    stroke: 'yellowgreen',
    strokeWidth: 3,
    lineJoin: 'round',
    tension: 0.5
  });
  
  layer.add(todor);
  layer.add(todorText);
  layer.add(todorLine); 
   
  // PETRA
  var petra = new Kinetic.Rect({
    x: 450,
    y: 50,
    width: 200, 
    height: 70,
    strokeWidth: 3,
    stroke: 'yellowgreen',
    fill: 'pink',
    cornerRadius: 25
  });
  
  var petraText = new Kinetic.Text({
      x: 467,
      y: 68,
      text: familyMembers[1].mother,
      fontSize: 25,
      fontFamily: 'Calibri',
      stroke: 'black',
      fill: 'black',
  });
  
  var petraLine = new Kinetic.Line({
    points: [550, 120, 510, 170, 420, 180, 400, 200],
    stroke: 'yellowgreen',
    strokeWidth: 3,
    lineJoin: 'round',
    tension: 0.5
  });
  
  layer.add(petra);
  layer.add(petraText);
  layer.add(petraLine);
  
  // MARIA
  var maria = new Kinetic.Rect({
    x: 300,
    y: 200,
    width: 200, 
    height: 70,
    strokeWidth: 3,
    stroke: 'yellowgreen',
    fill: 'pink',
    cornerRadius: 25
  });
  
  var mariaText = new Kinetic.Text({
      x: 328,
      y: 220,
      text: familyMembers[1].children[0],
      fontSize: 25,
      fontFamily: 'Calibri',
      stroke: 'black',
      fill: 'black',
  });
  
    
  var mariaLine1 = new Kinetic.Line({
    points: [400, 270, 370, 310, 300, 325, 270, 350],
    stroke: 'yellowgreen',
    strokeWidth: 3,
    lineJoin: 'round',
    tension: 0.5
  });
  
  var mariaLine2 = new Kinetic.Line({
    points: [400, 270, 450, 320, 520, 330, 570, 350],
    stroke: 'yellowgreen',
    strokeWidth: 3,
    lineJoin: 'round',
    tension: 0.5
  });
  
  layer.add(maria);
  layer.add(mariaText);
  layer.add(mariaLine1);
  layer.add(mariaLine2);
  
 // GEORGI
 var georgi = new Kinetic.Rect({
    x: 50,
    y: 200,
    width: 190, 
    height: 70,
    strokeWidth: 3,
    stroke: 'yellowgreen',
    fill: 'skyblue',
    cornerRadius: 10
  });
  
  var georgiText = new Kinetic.Text({
      x: 74,
      y: 220,
      text: familyMembers[0].father,
      fontSize: 25,
      fontFamily: 'Calibri',
      stroke: 'black',
      fill: 'black',
  });
  
  var georgiLine = new Kinetic.Line({
    points: [150, 270, 170, 310, 220, 320, 260, 350],
    stroke: 'yellowgreen',
    strokeWidth: 3,
    lineJoin: 'round',
    tension: 0.5
  });
  
  layer.add(georgi);
  layer.add(georgiText);
  layer.add(georgiLine);
  
  // PETER
   var peter = new Kinetic.Rect({
    x: 180,
    y: 350,
    width: 190, 
    height: 70,
    strokeWidth: 3,
    stroke: 'yellowgreen',
    fill: 'skyblue',
    cornerRadius: 10
  });
  
  var peterText = new Kinetic.Text({
      x: 210,
      y: 370,
      text: familyMembers[0].children[1],
      fontSize: 25,
      fontFamily: 'Calibri',
      stroke: 'black',
      fill: 'black',
  });
  
  layer.add(peter);
  layer.add(peterText);
  
  // TEODORA
  var teodora = new Kinetic.Rect({
    x: 480,
    y: 350,
    width: 200, 
    height: 70,
    strokeWidth: 3,
    stroke: 'yellowgreen',
    fill: 'pink',
    cornerRadius: 25
  });
  
  var teodoraText = new Kinetic.Text({
      x: 497,
      y: 370,
      text: familyMembers[0].children[0],
      fontSize: 25,
      fontFamily: 'Calibri',
      stroke: 'black',
      fill: 'black',
  });
  
  layer.add(teodora);
  layer.add(teodoraText);

  stage.add(layer);
    