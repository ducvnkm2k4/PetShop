function checkInputFormSignUp() {
    let txtName = document.getElementById("txtName");
    let notifyName = document.getElementById("notifyName");

    let txtGmail = document.getElementById("txtGmail");
    let notifyGmail = document.getElementById("notifyGmail");

    let txtSDT = document.getElementById("txtSDT");
    let notifySDT = document.getElementById("notifySDT");

    let txtDiaChi = document.getElementById("txtDiaChi");
    let notifyDiaChi = document.getElementById("notifyDiaChi");

    let txtpassword = document.getElementById("txtPassword");
    let notifypassword = document.getElementById("notifyPassword");

    //tên trống
    if (!checkInputText(txtName, notifyName, "Tên đang trống")) return false;
    //gmail trống
    if (!checkInputText(txtGmail, notifyGmail, "Gmail đang trống")) return false;
    //địa chỉ trống
    if (!checkInputText(txtDiaChi, notifyDiaChi, "Địa chỉ đang trống")) return false;
    //password trống
    if (!checkInputText(txtpassword, notifypassword, "Mật khẩu đang trống")) return false;
    //check gmail
    if (!checkInputGmail(txtGmail, notifyGmail)) return false;
    //check Số điện thoại
    if (!checkInputPhoneNumber(txtSDT, notifySDT)) return false;
    //check password
    if (!checkInputPassword(txtpassword, notifypassword)) return false;
    return true;
}

function checkInputFormLogin() {
    let txtGmail = document.getElementById("txtGmail");
    let notifyGmail = document.getElementById("notifyEmail");
    let txtpassword = document.getElementById("txtPassword");
    let notifypassword = document.getElementById("notifyPassword");

    if (!checkInputText(txtGmail, notifyGmail, "Gmail đang trống")) return false;

    if (!checkInputText(txtpassword, notifypassword, "Mật khẩu đang trống")) return false;

    if (!checkInputGmail(txtGmail, notifyGmail)) return false;

    if (!checkInputPassword(txtpassword, notifypassword)) return false;

    return true;
}

function checkInputFormOrder() {
    let txtName = document.getElementById("txtName");
    let notifyName = document.getElementById("notifyName");

    let txtGmail = document.getElementById("txtGmail");
    let notifyGmail = document.getElementById("notifyGmail");

    let txtSDT = document.getElementById("txtSDT");
    let notifySDT = document.getElementById("notifySDT");

    let txtDiaChi = document.getElementById("txtDiaChi");
    let notifyDiaChi = document.getElementById("notifyDiaChi");

    //tên trống
    if (!checkInputText(txtName, notifyName, "Tên đang trống")) return false;
    //gmail trống
    if (!checkInputText(txtGmail, notifyGmail, "Gmail đang trống")) return false;
    //Số điện thoại trống
    if (!checkInputText(txtSDT, notifySDT, "Số điện thoại đang trống")) return false;
    //địa chỉ trống
    if (!checkInputText(txtDiaChi, notifyDiaChi, "Địa chỉ đang trống")) return false;
    //check gmail
    if (!checkInputGmail(txtGmail, notifyGmail)) return false;
    //check Số điện thoại
    if (!checkInputPhoneNumber(txtSDT, notifySDT)) return false;
    return true;
}

///// check funtion 
function checkInputText(input, notifyElement, message) {
    if (input.value.trim().length == 0) {
        input.focus();
        input.select();
        input.style.border = "1px solid red";
        notifyElement.innerText = message;
        return false;
    } else {
        input.style.border = "1px solid black";
        notifyElement.innerText = "";
    }
    return true;
}

function checkInputGmail(input, notifyElement) {
    if (input.value.indexOf("@gmail.com") < 0) {
        input.focus();
        input.select();
        input.style.border = "1px solid red";
        notifyElement.innerText = "gmail không đúng định dạng (có chứa '@gmail.com' và không chứa ký tự tiếng việt)";
        return false;
    } else {
        input.style.border = "1px solid black";
        notifyElement.innerText = "";
    }
    return true;
}

function checkInputPhoneNumber(input, notifyElement) {
    if (input.value.trim().length != 0 && ! /^\d{10}$/.test(input.value)) {
        input.focus();
        input.style.border = "1px solid red";
        notifyElement.innerText = "Số điện thoại không hợp lệ";
        return false;
    } else {
        input.style.border = "1px solid black";
        notifyElement.innerText = "";
    }
    return true;
}

function checkInputPassword(input, notifyElement) {
    if (input.value.trim().length < 6) {
        input.focus();
        input.select();
        input.style.border = "1px solid red";
        notifyElement.innerText = "mật khẩu cần ít nhất 6 ký tự";
        return false;
    } else {
        input.style.border = "1px solid black";
        notifyElement.innerText = "";
    }
    return true;
}