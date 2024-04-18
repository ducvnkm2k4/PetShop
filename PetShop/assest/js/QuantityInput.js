var quantity = document.getElementById("quantity");

quantity.addEventListener("keydown", function (event) {
    var charCode = event.which || event.keyCode;
    var quantityValue = quantity.value;

    if ((charCode >= 48 && charCode <= 57) || charCode === 8 || charCode === 46) {
        if (parseInt(quantityValue) > 5000 && (charCode >= 48 && charCode <= 57)) {
            event.preventDefault();
        }
    } else {
        event.preventDefault();
    }
});


quantity.addEventListener("input", function (event) {
    var quantityValue = quantity.value;

    if (quantityValue === "") {
        quantity.value = 0;
    } else if (quantityValue.indexOf("0") === 0) {
        quantity.value = quantityValue.slice(1);
    }

});