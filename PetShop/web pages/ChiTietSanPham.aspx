<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="PetShop.web_pages.ChiTietSanPham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng bán đồ và phụ kiện cho thú cưng</title>
    <link rel="stylesheet" href="../assest/font/themify-icons/themify-icons.css" />
    <link rel="stylesheet" href="../assest/font/fontawesome-free-6.5.2-web/css/all.min.css" />
    <link rel="stylesheet" href="../assest/css/ChiTietSanPham.css" />

</head>
<body>
     <input type="checkbox" id="chk_visibleContainerLogin" class="chk_visibleContainerLogin" hidden="hidden"/>
    <input type="checkbox" id="chk_visibleContainerSignUp" class="chk_visibleContainerSignUp" hidden="hidden"/>

    <label for="chk_visibleContainerLogin" class="overlay" id="overlayLogin"></label>
    <label for="chk_visibleContainerSignUp" class="overlay" id="overlaySignUp"></label>

    <div class="Container_Login">

        <label for="chk_visibleContainerLogin"> <i class="fa-solid fa-xmark" id="btncloseformlogin"></i> </label>

        <i class="fa-solid fa-chevron-left" id="backToLogin"></i>
        <form action="XuLyLogin_Logout_SignUp.aspx?request=login&preUrl=<%=Request.Url.AbsoluteUri %>" method="post" class="login">
            <h2 class="title">Đăng Nhập</h2>

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
                <div>Bạn quên mật khẩu,<span class="action" title="Quên mật khẩu">Quên mật khẩu</span></div>
                <div>Bạn chưa có tài khoản,<span class="action" title="Đăng ký">Đăng ký</span></div>
            </div>
        </form>
        <!---- form forgot password--->
        <form action="XuLyLogin_Logout_SignUp.aspx?request=login&preUrl=<%=Request.Url.AbsoluteUri %>" method="get" class="forgotPass">
            <h2 class="title">Quên mật khẩu</h2>
            <h3>Hãy nhập gmail của bạn để lấy lại mật khẩu</h3>
            <div>
                <input type="email" name="txtemailForgot" id="txtemailForgot" placeholder="abc@gmail.com" class="inpText"/>
            </div>
            <div><input type="submit" id="btnForgot" value="Lấy lại mật khẩu" /></div>
        </form>
    </div>
    <!--- đăng ký--->
    <div class="container_SignUp">
        <label for="chk_visibleContainerSignUp"> <i class="fa-solid fa-xmark" id="btncloseformsignup"></i> </label>

        <form action="XuLyLogin_Logout_SignUp.aspx?request=login&preUrl=<%=Request.Url.AbsoluteUri %>" method="get" class="signup">
            <h2>Đăng ký tài khoản</h2>

            <div class="container_SignUp__Name">
                <h3>Họ và tên <span>*</span></h3>
                <input type="text" id="txtName" placeholder="nguyễn văn a" class="inpText"/>
                <div><span id="notifyNameSignUp"></span></div>
            </div>

            <div class="container_SignUp__gmail">
                <h3>Gmail<span>*</span></h3>
                <input type="email" id="txtgmailsignup" placeholder="abc@gmail.com" class="inpText"/>
                <div><span id="notifygmailSignUp"></span></div>
            </div>

            <div class="container_SignUp__SDT">
                <h3>Số điện thoại</h3>
                <input type="text" id="txtSDT" placeholder="số điện thoại" class="inpText"/>
                <div><span id="notifySDTSignUp"></span></div>
            </div>

            <div class="container_SignUp__Address">
                <h3>Địa chỉ<span>*</span></h3>
                <input type="text" id="txtDiaChi" placeholder="địa chỉ" class="inpText"/>
                <div><span id="notifyDiaChiSignUp"></span></div>
            </div>
            
            <div class="container_SignUp__password">
                <h3 >Mật khẩu<span>*</span></h3>
                <input type="password" id="txtPasswordSignup" placeholder="mật khẩu" class="inpText"/>
                <div><span id="notifyPasswordSignUp"></span></div>
            </div>

            <div class="container_SignUp__submit">
                <input type="submit" id="btnSignup" value="Đăng ký" />
            </div>

            <div class="container_SignUp__content">
                Bạn đã có tài khoản? <span id="contentLogin" style="cursor:pointer">Đăng nhập</span>
            </div>
        </form>
    </div>

    <!-- header -->
   <header class="header">
        <input type="checkbox" class="check_navBar" name="check_navBar" id="check_navBar" hidden="hidden"/>
        <label for="check_navBar" class="overLayNavBar"></label>
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

    <!------------------------------------ main body------------------------------>
    <main>
        <!-- title-->
        <h1 class="title" style="text-align:center;width:100%">Thông tin sản phẩm</h1>

        <!--infomation--->
        <div class="Container_info_product">
            <!---thông tin--->
            <div class="product_details">
                <div class="product_image" id="product_image" runat="server">
                    <img src="../assest/images/Cho/sp-01.jpg" class="product_image"/>
                </div>
                <div class="Container_info">
                    <div class="product_name" id="product_name" runat="server">
                    Thức Ăn Khô Cho Chó Con Smart Heart Gold Puppy 1kg
                    </div>
                    <div class="product_price" id="product_price" runat="server">
                        1115000
                    </div>
                    <div class="product_detail" id="product_detail" runat="server">
                        Sản phẩm Thức Ăn Khô Cho Chó Con Smart Heart Gold Puppy 1kg là loại thức ăn hạt dành riêng cho chó nhỏ
                        tầm dưới 12 tháng tuổi. Dòng sản phẩm SmartHeart đang ngày càng được ưa chuộng trong cộng đồng thú cưng
                        vì hương vi thơm ngon, dễ ăn và được các bé cún yêu thích.
                    </div>
                </div>
            </div>
            <a href="GioHang.aspx?request=addItem&urlrequest=<%=Request.Url.AbsoluteUri%>&id=<%=Request.QueryString["pi"] %>">
                <input type="submit" value="Thêm vào giỏ hàng" class="btnadd" id="btnadd" />
            </a>
        </div>

    </main>

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
