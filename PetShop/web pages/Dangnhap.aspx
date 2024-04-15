﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangnhap.aspx.cs" Inherits="PetShop.web_pages.Danhnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng bán đồ và phụ kiện cho thú cưng</title>
    <!---- link font icon --->
    <link rel="stylesheet" href="../assest/font/themify-icons/themify-icons.css" />
    <link rel="stylesheet" href="../assest/font/fontawesome-free-6.5.2-web/css/all.min.css" />

    <link rel="stylesheet" href="../assest/css/Dangnhap.css" />
</head>
<body>
    <header class="header">
        <input type="checkbox" class="check_navBar" name="check_navBar" id="check_navBar" hidden="hidden"/>
        <label for="check_navBar" class="overlay" id="overLayNavBar"></label>
        <!-- TOP BAR--->
        <div class="header__topbar" >
            <div class="topbar__left"> Cửa hàng bán đồ và phụ kiện cho thú cưng</div>
            <div class="topbar__right taikhoan" id="taikhoan" runat="server">Đăng nhập|Đăng ký</div>
        </div>

        <!----- BOTTOM BAR -->
        <label for="check_navBar"><i class="fa-solid fa-bars"></i></label>
        <div class="header__bottombar">
            <!--LOGO--->
            <div class="header__logo">
                <a href="TrangChu.aspx" class="header__logo">
                    <img src="../assest/images/logomeo.jpg" style="width:70px" />
                    <span>PET</span>
                </a>
            </div>
            <!--SEARCH--->
            <div class="header__search">
                <input type="text" name="txtSearch" id="txtSearch" placeholder="Bạn cần tìm gì...." />
                <a href="#" class="ic_search"><i class="ti-search"style="color:black"></i></a>
            </div>
            <!-- SHOPPING CART-->
            <div class="header__shopping_cart">
                <a href="GioHang.aspx"><i class="ti-shopping-cart"></i></a>
                <div class="text-cart">
                    <span>Giỏ hàng</span>
                    <div id="numOfProduct" runat="server">0</div>
                    <p>sản phẩm</p>
                </div>
            </div>
        </div>
         <!-- Nav bar-->
        <div class="navBar_Container">
             <div class="taikhoan tknavbar" id="taikhoannavbar" runat="server">Đăng nhập|Đăng ký</div>
            <label for="check_navBar" style="display:inline;"><i class="fa-solid fa-xmark"></i></label>

            <nav class="header__navbar">
                <ul class="menu_list">
                    <li><a href="TrangChu.aspx">Trang chủ</a></li>
                    <li><a href="SanPhamCho.aspx">Chó</a></li>
                    <li><a href="SanPhamMeo.aspx">Mèo</a></li>
                    <li><a href="#">Giới thiệu</a></li>
                    <li><a href="#">Liên hệ</a></li>
                </ul>
            </nav>
        </div>
    </header>

    <form action="XuLyLogin_Logout_SignUp.aspx?request=login" method="post" class="loginForm">
        <div>
            <h1 class="title">Đăng Nhập</h1>

            <div class="Container_Login__NameLogin">
                <h3>Tên đăng nhập<span>*</span> </h3>
                <div><input type="email" name="txtNameLogin" id="txtNameLogin" placeholder="abc@gmail.com" class="inpText"/></div>
                <div><span id="notifyEmailLogin"></span></div>
            </div>

            <div class="Container_Login__password">
                <h3>Mật khẩu<span>*</span></h3>
                <div>
                    <input type="password" name="txtPassword" id="txtPasswordLogin" placeholder="mật khẩu" class="inpText"/>
                    <div><span id="notifyPasswordLogin"></span></div>
                </div>
            </div>

            <div class="Container_Login__submit">
                <input type="submit" id="btnLogin" name="btnLogin" value="Đăng nhập" />
            </div>

            <div class="content">
                <div>Bạn quên mật khẩu,<a href="QuenMatKhau.aspx"><span>Quên mật khẩu</span></a></div>
                <div>Bạn chưa có tài khoản,<a href="Dangky.aspx"><span>Đăng ký</span></a></div>
            </div>
        </div>
    </form>

     <footer class="footer">
        <div class="footer_left">
            <h3>PET</h3>
            <br/>
            <h4>Môn: Lập trình web cơ bản</h4>
            <h4>Đề tài: Website bán đồ và phụ kiện cho thú cưng</h4>
            <h4>Giáo viên hướng dẫn: Lê Hữu Dũng</h4>
        </div>

        <div class="footer_right">
            <h3>Thành viên:</h3>
            <br/>
            <h4>Vũ Việt Cường</h4>
            <h4>Nguyễn Đình Minh Đức</h4>
            <h4>Trần Kim Quang Vinh</h4>
        </div>
    </footer>
</body>
</html>