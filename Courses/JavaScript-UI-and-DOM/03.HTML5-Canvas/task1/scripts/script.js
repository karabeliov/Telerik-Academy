(function () {
    var canvas = document.getElementById('the-canvas');
    canvas.width = 800;
    canvas.height = 600;
    var ctx = canvas.getContext('2d');
    
    // grass
    ctx.stroke();
    ctx.moveTo(0, 300);
    ctx.fillStyle = 'green';
    ctx.fillRect(0, 300, 800, 300);
    
    ctx.moveTo(0, 0);
    ctx.fillStyle = 'skyblue';
    ctx.fillRect(0, 0, 800, 300);
    
    // mountain
    ctx.beginPath();
    ctx.fillStyle = 'darkgreen';
    ctx.strokeStyle = 'black';
    
    ctx.moveTo(0, 300);
    ctx.bezierCurveTo(80,110,200,110,300,300);
    ctx.stroke();
    ctx.fill();
    
    ctx.beginPath();
    ctx.fillStyle = 'darkgreen';
    ctx.strokeStyle = 'black';
    
    ctx.moveTo(420, 300);
    ctx.bezierCurveTo(720,110,900,110,800,300);
    ctx.stroke();
    ctx.fill();
    
    // House
    ctx.lineWidth = 2;
    ctx.fillStyle = 'pink';
    ctx.strokeStyle = 'black';
    ctx.fillRect(80, 380, 200, 200);
    ctx.strokeRect(80, 380, 200, 200);
    
    ctx.beginPath();
    ctx.fillStyle = 'darkRed';
    ctx.moveTo(80, 380);
    ctx.lineTo(180, 260);
    ctx.lineTo(280, 380);
    ctx.fill();
    ctx.stroke();
    
    ctx.moveTo(180, 260);
    ctx.lineTo(400, 230);
    ctx.lineTo(500, 340);
    ctx.lineTo(280, 380);
    ctx.fill();
    ctx.stroke();
    
    ctx.beginPath();
    ctx.fillStyle = 'pink';
    ctx.moveTo(280, 580);
    ctx.lineTo(500, 520);
    ctx.lineTo(500, 340);
    ctx.lineTo(280, 380);
    ctx.lineTo(280, 580);
    ctx.moveTo(280, 380);
    ctx.lineTo(80, 380);
    ctx.fill();
    ctx.stroke();
    ctx.closePath();
    
    
    // windows
    ctx.beginPath();
    ctx.fillStyle = 'black';
    ctx.strokeStyle = 'pink';
    ctx.moveTo(280, 580);
    ctx.fillRect(100, 410, 50, 50);
    ctx.moveTo(125, 410);
    ctx.lineTo(125, 460); 
    ctx.moveTo(100, 435);
    ctx.lineTo(150, 435);
    ctx.stroke();
    
    ctx.fillRect(200, 410, 50, 50);
    ctx.moveTo(225, 410);
    ctx.lineTo(225, 460);
    ctx.moveTo(200, 435);
    ctx.lineTo(250, 435);
    ctx.stroke();
    
    // door
    ctx.beginPath();
    ctx.fillStyle = 'black';
    ctx.fillRect(180, 500, 50, 80);
    
    // cloud
    ctx.beginPath();
    ctx.fillStyle = 'white';
    ctx.strokeStyle = 'white';
    ctx.moveTo(20,20);
    ctx.bezierCurveTo(20,50,200,80,200,20);
    
    ctx.moveTo(20,20);
    ctx.bezierCurveTo(100,10,100,10,200,20);
    ctx.fill();
    ctx.stroke();
    
    ctx.beginPath();
    ctx.fillStyle = 'white';
    ctx.strokeStyle = 'white';
    ctx.moveTo(400,20);
    ctx.bezierCurveTo(400,10,300,80,600,20);
    
    ctx.moveTo(400,20);
    ctx.bezierCurveTo(600,0,600,0,600,20);
    ctx.fill();
    ctx.stroke();
    
    // byke
    
     // wheels
    ctx.beginPath();
    ctx.moveTo(580, 550);
    ctx.arc(580,550, 20,0,2*Math.PI);
    ctx.moveTo(680, 480);
    ctx.lineTo(720, 550);
    ctx.moveTo(740, 550);
    ctx.arc(720,550,20,0,2*Math.PI);
    
    // steering wheel
    ctx.moveTo(710, 450);
    ctx.lineTo(680, 480);
    ctx.moveTo(680, 480);
    ctx.lineTo(650, 490);
    ctx.lineWidth = 2;
    ctx.fillStyle = 'skyblue';
    ctx.fill();
    ctx.lineWidth = 4;
    ctx.strokeStyle = 'DarkCyan';
    ctx.stroke();
    
    // move wheel
    ctx.moveTo(660, 550);
    ctx.arc(650,550,10,0,2*Math.PI);
    ctx.moveTo(600, 550);
    ctx.lineTo(650, 550);
    ctx.moveTo(655, 560);
    ctx.lineTo(660, 565);
    ctx.stroke();
    // constr
    ctx.beginPath();
    ctx.moveTo(650, 550);
    ctx.lineTo(700, 510);
    ctx.lineTo(625, 510);
    ctx.lineTo(580, 550);
    ctx.stroke();
    
    ctx.moveTo(650, 550);
    ctx.lineTo(615, 495);
    ctx.moveTo(600, 495);
    ctx.lineTo(630, 495);
    ctx.stroke();
    ctx.closePath();
}());