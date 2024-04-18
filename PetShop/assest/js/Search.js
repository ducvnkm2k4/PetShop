var searchIcon = document.querySelector(".ic_search");
var txtSearch = document.getElementById("txtSearch");

txtSearch.addEventListener("keydown", function (event) {
    let keychar = event.key || event.keyCode;
    let searchkey = txtSearch.value.trim();
    if (searchkey.length != 0 && (keychar === "Enter" || keychar === 13)) {
        window.location.href = "SanPham.aspx?type=search&key=" + searchkey;
    }
});

searchIcon.addEventListener("click", function () {
    let searchkey = txtSearch.value.trim(); 
    if (searchkey.length == 0) {
        alert("Hãy nhập thông tin cần tìm kiếm");
    } else {
        window.location.href = "SanPham.aspx?type=search&key=" + searchkey;
    }
});
