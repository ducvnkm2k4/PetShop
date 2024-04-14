<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="PetShop.web_pages.TrangChu" %>
<%@ Import Namespace="PetShop" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng bán đồ và phụ kiện cho thú cưng</title>
    <link rel="stylesheet" href="../assest/font/themify-icons/themify-icons.css" />
    <link rel="stylesheet" href="../assest/font/fontawesome-free-6.5.2-web/css/all.min.css" />
    <link rel="stylesheet" href="../assest/css/TrangChu.css" />
</head>
<body>
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
                    <li><a href="TrangChu.aspx" style="color:#FA8072;">Trang chủ</a></li>
                    <li><a href="SanPhamCho.aspx">Chó</a></li>
                    <li><a href="SanPhamMeo.aspx">Mèo</a></li>
                    <li><a href="#">Giới thiệu</a></li>
                    <li><a href="#">Liên hệ</a></li>
                </ul>
            </nav>
        </div>
    </header>


    <main>
        <div class="Container_Banner">
            <div class="banner">
                 <div class="slide fade">
                    <div class="page">1/3</div>
                     <img src="../assest/images/meo2.png" alt="Banner phụ kiện" class="image_banner" />
                    <div class="text">Phụ kiện</div>
                </div>

                <div class="slide fade">
                    <div class="page">2/3</div>
                    <img src="../assest/images/meo1.jpg" alt="Banner Mèo" class="image_banner"/>
                    <div class="text">Mèo</div>
                </div>

                <div class="slide fade">
                    <div class="page">3/3</div>
                    <img src="../assest/images/pk1.jpg" alt="Banner chó" class="image_banner"/>
                    <div class="text">Chó</div>
                </div>

                <div class="arrow">
                    <!-- dấu mũi tên -->
                    <a class="prev" onclick="nextSlide(-1)"><i class="fa-solid fa-chevron-left"></i></a>
                    <a class="next" onclick="nextSlide(1)"><i class="fa-solid fa-chevron-right"></i></a>
                </div>
            </div>
       
            <!-- dấu chấm hiện chuyển slide -->
            <div style="text-align:center">
                <span class="dot" onclick="chuyenSlide(1)"></span>
                <span class="dot" onclick="chuyenSlide(2)"></span>
                <span class="dot" onclick="chuyenSlide(3)"></span>
            </div>
        </div>
            <div class="container_item">
            <div class="item">
                <div class="icon"><i class="ti-gift"></i></div>
                <div class="item_infor">Các sản phẩm <br/> phong phú</div>
            </div>
            <div class="item">
                <div class="icon"><i class="ti-money"></i></div>
                <div class="item_infor">Khuyến mại <br/> hấp dẫn</div>
            </div>
            <div class="item">
                <div class="icon"><i class="ti-info"></i></div>
                <div class="item_infor">Thông tin <br/>rõ ràng </div>
            </div>
            <div class="item">
                <div class="icon"><i class="ti-truck"></i></div>
                <div class="item_infor">Vận chuyển <br/>nhanh chóng </div>
            </div>
        </div>  

        <h1 class="title">Sản phẩm bán chạy</h1>

        <div class="product-list" id="product_list" runat="server"></div>
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
    <script src="../assest/js/slideshow.js"></script>
   
</body>
</html>
