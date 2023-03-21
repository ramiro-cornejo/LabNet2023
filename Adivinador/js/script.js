
var secretNumber = Math.floor(Math.random() * 20) + 1;

var puntaje = 10;

var numeroInput = document.getElementById("numeroInput");
var adivinarButton = document.getElementById("adivinarButton");
var mensaje = document.getElementById("mensaje");
var puntajeDisplay = document.getElementById("puntaje");


function adivinarNum() {
  var adivinar = parseInt(numeroInput.value);

  if (adivinar === secretNumber) {
    mensaje.innerHTML = "¡Felicitaciones, ganaste!";
    if (puntaje > parseInt(localStorage.getItem("highScore"))) {
      localStorage.setItem("highScore", puntaje);
    }
    puntajeDisplay.innerHTML = "Puntaje más alto: " + localStorage.getItem("highScore");
  } else {
    puntaje--;
    mensaje.innerHTML = "Intenta nuevamente. Puntaje: " + puntaje;

    if (puntaje === 0) {
      mensaje.innerHTML = "Perdiste. El número era " + secretNumber;
      puntajeDisplay.innerHTML = "";
    }
  }

  numeroInput.value = "";
  numeroInput.focus();
}

if (!localStorage.getItem("highScore")) {
  localStorage.setItem("highScore", 0);
}
puntajeDisplay.innerHTML = "Puntaje más alto: " + localStorage.getItem("highScore");

function reiniciarVista() {
  window.location.reload();
}
