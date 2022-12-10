const minusButton = document.getElementById('minus');
const plusButton = document.getElementById('plus');
const inputField = document.getElementById('input');





function plus(event) {
    event.preventDefault();
    var buttonclicked = event.target.parentElement.parentElement.parentElement;
    var input = buttonclicked.querySelector("input");
    const currentValue = Number(input.value) || 0;
    if (currentValue >= 0 && currentValue < 9) {
        input.value = currentValue + 1;
    }
};

function minus(event) {
    event.preventDefault();
    var buttonclicked = event.target.parentElement.parentElement.parentElement;
    var input = buttonclicked.querySelector("input");
    const currentValue = Number(input.value) || 0;
    if (currentValue > 0 && currentValue<=9) {
        input.value = currentValue - 1;
    }
   
}
