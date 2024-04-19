<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="PetShop.web_pages.ChiTietSanPham" %>
<%@ Import Namespace="PetShop" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng bán đồ và phụ kiện cho thú cưng</title>
    <link rel="stylesheet" href="../assest/font/themify-icons/themify-icons.css" />
    <link rel="stylesheet" href="../assest/font/fontawesome-free-6.5.2-web/css/all.min.css" />
    <link rel="stylesheet" href="../assest/css/ChiTietSanPham.css" />

</head>
<body>

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
            <form id="form1" runat="server">
                <asp:Button class="btnadd" id="btnadd" Text="Thêm vào giỏ hàng" OnClick="btnAdd_click"  runat="server"/>
            </form>
            
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
    <div id="serverData" runat="server"></div>
    <script src="../assest/js/Search.js"></script>
    <script src="../assest/js/addcartItem.js"></script>
    
</body>
</html>
