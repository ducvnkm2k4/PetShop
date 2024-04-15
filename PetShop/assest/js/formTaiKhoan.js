
function checkInputFormLogin() {


}

function inputError(input, elementNotify, message) {
    input.style.border = "1px solid red";
    elementNotify.innerText = message;
    input.focus();
    input.select();
    return false;
}

function inputCorrect(input, elementNotify) {
    input.style.border = "1px solid black";
    elementNotify.innerText = "";
    return true;
}

function checkInputText(input, elementNotify, message) {
    if (input.value.trim().length == 0) {
       
        return inputError(input, elementNotify, message);
    }
    else {
        
        return inputCorrect(input, elementNotify);
    }
}

function checkInputEmail(input, elementNotify) {
    
    var gmailRegex = /^[a-zA-Z0-9._%+-]+@gmail\.com$/;
    
    if (!gmailRegex.test(input)) {
        return inputError(input, elementNotify,"không đúng định dạng của gmail");
    } else return inputCorrect(input, elementNotify);
}

function checkInputPassword(input, elementNotify, message) {

    if (input.value.trim().length < 6) {
        input.style.border = "1px solid red";
        elementNotify.innerText = message;
        input.focus();
        return false;
    } else {
        input.style.border = "1px solid black";
        elementNotify.innerText = "";
        return true;
    }
}

