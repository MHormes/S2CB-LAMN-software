// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

var modal = document.getElementById("modal");

window.onclick = function(event) {
    if (event.target == modal) {
      modal.style.display = "none";
    }
}

span.onclick = function() {
    modal.style.display = "none";
}