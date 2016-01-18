    var canvas = document.getElementById('the-canvas-byke');
    canvas.width = 500;
    canvas.height = 20;
    var ctx = canvas.getContext('2d');
    
    // wheels
    ctx.moveTo(300, 150);
    ctx.arc(300,150,50,0,2*Math.PI);
    ctx.moveTo(525, 40);
    ctx.lineTo(560, 150);
    ctx.moveTo(610, 150);
    ctx.arc(560,150,50,0,2*Math.PI);
    
    // steering wheel
    ctx.moveTo(525, 40);
    ctx.lineTo(570, 10);
    ctx.moveTo(525, 40);
    ctx.lineTo(480, 50);
    ctx.lineWidth = 2;
    ctx.fillStyle = 'red';
    ctx.fill();
    ctx.lineWidth = 2;
    ctx.strokeStyle = 'red';
    ctx.stroke();
    
    // move wheel
    ctx.moveTo(430, 150);
    ctx.arc(430,150,15,0,2*Math.PI);
    ctx.moveTo(440, 160);
    ctx.lineTo(450, 170);
    ctx.moveTo(420, 140);
    ctx.lineTo(408, 127);
    ctx.stroke();
    // constr
    ctx.beginPath();
    ctx.moveTo(350, 150);
    ctx.lineTo(430, 150);
    ctx.lineTo(530, 70);
    ctx.lineTo(370, 70);
    ctx.lineTo(300, 150);
    ctx.stroke();
    
    ctx.moveTo(430, 150);
    ctx.lineTo(350, 40);
    ctx.moveTo(325, 40);
    ctx.lineTo(380, 40);
    ctx.stroke();
    ctx.closePath();