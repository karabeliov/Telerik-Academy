function countMove() {
    var display = document.getElementById('counterMovement');
    setInterval(function () {
        
        display.innerHTML = 'Плавания: ' + game.movesMade;
        //console.log('Moves made: ' + game.movesMade)
    }, 1000);
}