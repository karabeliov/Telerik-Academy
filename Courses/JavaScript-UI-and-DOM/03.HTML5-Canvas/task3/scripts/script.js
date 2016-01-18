  var stageWidth = 300,
    stageHeight = 300,
    stage = new Kinetic.Stage({
    container: 'container',
    //width: document.body.clientWidth
    width: stageWidth,
    height: stageHeight
  });

  var layer = new Kinetic.Layer();
  
  var ball = new Kinetic.Line({
    points: [73, 70, 340, 23, 450, 60, 500, 20],
    strokeWidth: 5,
    stroke: 'orange'
  });
  
  layer.add(ball);
  stage.add(layer);
    