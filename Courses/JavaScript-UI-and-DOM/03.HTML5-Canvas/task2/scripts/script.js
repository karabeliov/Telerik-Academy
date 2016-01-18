  var stage = new Kinetic.Stage({
    container: 'container',
    //width: document.body.clientWidth
    width: 800,
    height: 600
  });

  var layer = new Kinetic.Layer();
  
  var ball = new Kinetic.Circle({
    x: 25,
    y: 25,
    radius: 20,
    fill: 'yellow',
    stroke: 'orange'
  });
  
  var updateX = 8,
      updateY = 15;
      
  function animFrame() {
    var x = ball.getX() + updateX,
        y = ball.getY() + updateY,
        r = ball.getRadius() + 0.05;
    if (y < ball.getRadius() || y > stage.getHeight() - ball.getRadius()) {
      updateY = updateY * -1;
    }
    if (x < ball.getRadius() || x > stage.getWidth() - ball.getRadius()) {
      updateX = updateX * -1;
    }
    
    ball.setX(x);
    ball.setY(y);
    
    layer.draw();
    //setTimeout(animFrame, 30);
    requestAnimationFrame(animFrame);
  }
  
  animFrame();
  layer.add(ball);
  stage.add(layer);
    