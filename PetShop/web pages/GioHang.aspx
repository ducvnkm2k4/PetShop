<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="PetShop.web_pages.GioHang" %>
<%@ Import Namespace="PetShop" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng bán đồ và phụ kiện cho thú cưng</title>
    <!---- link font icon --->
    <link rel="stylesheet" href="../assest/font/themify-icons/themify-icons.css" />
    <link rel="stylesheet" href="../assest/font/fontawesome-free-6.5.2-web/css/all.min.css" />

    <link rel="stylesheet" href="../assest/css/GioHang.css" />

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
                <input type="text" name="txtSearch" id="txtSearch" placeholder="Bạn cần tìm gì...." runat="server"/>
                <i class="ti-search ic_search" style="color:black"></i>
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
                    <li><a href="SanPham.aspx?type=cho" id="hd_cho" runat="server">Chó</a></li>
                    <li><a href="SanPham.aspx?type=meo" id="hd_meo" runat="server">Mèo</a></li>
                    <li><a href="#">Giới thiệu</a></li>
                    <li><a href="#">Liên hệ</a></li>
                </ul>
            </nav>
        </div>
    </header>
    
    <main>
        <h1 class="title">Giỏ hàng của bạn</h1>
        <div class="main_content">
            <section class="Container_cart" id="Container_cart" runat="server">
                <div class="sp">
                    <a href="ChiTietSanPham.aspx?pi=4"> <img src="../assest/images/Cho/sp-04.jpg" class="imgProduct"/></a>
                    <div class="info">
                        <a href="ChiTietSanPham.aspx?pi=4" style="color:black;"><h3 class="info__name">Sữa Tắm SOS Cho Chó Lông Trắng</h3></a>
                        <div class="info__cost">
                            <div class="price">Giá:120000</div>
                            <div>
                                <i class="fa-solid fa-plus" id="plus" runat="server"></i>
                                <input type="text" id="quantity" class="quantity" value="1" />
                                <i class="fa-solid fa-minus"></i>
                            </div>
                            <div class="totalCostProduct">Tổng:120000</div>
                            <i class="ti-trash" style="cursor:pointer;"></i>
                        </div>
                    </div>
                </div>
            </section>

            <section class="container_totalCost">
                <h1>Tổng giá trị đơn hàng</h1>
                <div class="container_totalCost__cost">
                    Thành tiền:
                    <span id="totalCost" runat="server">12146532315</span>
                </div>

                <div>
                    <a href="ThanhToanDonHang.aspx">
                        <input type="button" id="btnDatHang" class="btnDatHang" value="Đặt hàng" />
                    </a>
                </div>
            </section>
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
    <div id="serverData" data-value="<%=Application.Get(Global.LIST_SHOPPING_CART) %>"></div>

    
    <script src="../assest/js/QuantityInput.js"></script>
    <script src="../assest/js/Search.js"></script>
    <script>
    </script>

</body>
</html>
