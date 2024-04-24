<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DonDatHang.aspx.cs" Inherits="PetShop.web_pages.ThanhToanDonHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng bán đồ và phụ kiện cho thú cưng</title>
    <link rel="stylesheet" href="../assest/css/DonDatHang.css" />

    <script src="../assest/js/checkInput.js"></script>
</head>
<body>
    <form id="form_container" class="container" runat="server" onsubmit="return checkInputFormOrder()">
        <section class="customerInfo">
            <h2 class="title">Thông tin khách hàng</h2>
            <h4 id="title_login" runat="server">Bạn đã có tài khoản? hãy <a href="Dangnhap.aspx?preUrl=<%=Request.Url.AbsoluteUri %>"><span>đăng nhập.</span></a> </h4>
            <div class="orderInfo__customerInfo">
                <div class="customerInfo__Name">
                    <h3>Họ và tên <span>*</span></h3>
                    <input type="text" id="txtName" name="txtName" placeholder="nguyễn văn a" class="inpText" onfocus="onfocusInput(this,notifyName)" runat="server"/>
                    <div><span id="notifyName"></span></div>
                </div>

                <div class="CustomerInfo__gmail">
                    <h3>Gmail<span>*</span></h3>
                    <input type="text" id="txtGmail" name="txtGmail" placeholder="abc@gmail.com" class="inpText" onfocus="onfocusInput(this,notifyGmail)" runat="server" />
                    <div><span id="notifyGmail"></span></div>
                </div>

                <div class="CustomerInfo__SDT">
                    <h3>Số điện thoại<span>*</span></h3>
                    <input type="text" id="txtSDT" name="txtSDT" placeholder="số điện thoại" class="inpText" onfocus="onfocusInput(this,notifySDT)" runat="server"/>
                    <div><span id="notifySDT"></span></div>
                </div>

                <div class="CustomerInfo__Address">
                    <h3>Địa chỉ<span>*</span></h3>
                    <input type="text" id="txtDiaChi" name="txtDiaChi" placeholder="địa chỉ" class="inpText" onfocus="onfocusInput(this,notifyDiaChi)" runat="server"/>
                    <div><span id="notifyDiaChi"></span></div>
                </div>
                <div class="customerInfo__Note">
                    <h3>Ghi chú</h3>
                    <textarea style="width:100%;height:100px; resize:none;"></textarea>
                </div>
            </div>
        </section>

        <section class="paymentMethod">
            <h2 class="title">Phương thức thanh toán</h2>
            <div class="paymentContainer">
                <div class="cashOnDelivery">
                    <input type="radio" name="payment" id="cash" checked="checked" />
                    <label for="cash">Thanh toán khi nhận hàng</label>
                </div>
                <div class="bankTransfer">
                    <input type="radio" name="payment" id="bank" />
                    <label for="bank">Thanh toán qua ngân hàng</label>
                </div>
                <div class="momoWallet">
                    <input type="radio" name="payment" id="momo" />
                    <label for="momo">Thanh toán qua ví momo</label>
                </div>
                <div class="zaloPay">
                    <input type="radio" name="payment" id="zalo" />
                    <label for="zalo">Thanh toán qua ZaloPay</label>
                </div>
            </div>
        </section>


        <section class="orderInfo">
            <div class="title_orderInfo">
                <h2>Đơn hàng của bạn</h2>
                <a href="GioHang.aspx"><span>Giỏ hàng</span></a>
            </div>
        

            <section class="list_ProductSelected_container" id="cartItem_container" runat="server">
                <div class="cartitem" style="display:flex;">
                    <img src="../assest/images/Cho/sp-04.jpg" class="imgProduct" style="margin-right: 15px"/>
                    <div class="infor_CartItem">
                        <h3 class="info__name">Sữa Tắm SOS Cho Chó Lông Trắng</h3>
                        <div class="price">Giá:120000</div>
                        <div class="quantity">số lượng:1</div>
                        <div class="totalCostProduct">Tổng:120000</div>
                    </div>
                </div>
            </section>
            <section class="cost">
                <div class="container_totalCost__cost">
                    Thành tiền:
                    <span id="totalCostElement" runat="server">12146532315</span>
                </div>

                <div>
                    <asp:Button id="btnDatHang" class="btnDatHang" Text="Đặt hàng" OnClick="btnDatHang_Click" runat="server"/>
                </div>
            </section>
        </section>
    </form>
    
</body>
</html>
