<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThanhToanDonHang.aspx.cs" Inherits="PetShop.web_pages.ThanhToanDonHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <section class="orderInfo">
        <h2 class="title">Thông tin đơn hàng</h2>
        <div class="orderInfo__customerInfo">
            <div class="customerInfo__Name">
                <h3>Họ và tên <span>*</span></h3>
                <input type="text" id="txtName" name="txtName" placeholder="nguyễn văn a" class="inpText" onfocus="onfocusInput(this,notifyName)"/>
                <div><span id="notifyName"></span></div>
            </div>

            <div class="CustomerInfo__gmail">
                <h3>Gmail<span>*</span></h3>
                <input type="text" id="txtGmail" name="txtGmail" placeholder="abc@gmail.com" class="inpText" onfocus="onfocusInput(this,notifyGmail)"/>
                <div><span id="notifyGmail"></span></div>
            </div>

            <div class="CustomerInfo__SDT">
                <h3>Số điện thoại<span>*</span></h3>
                <input type="text" id="txtSDT" name="txtSDT" placeholder="số điện thoại" class="inpText" onfocus="onfocusInput(this,notifySDT)"/>
                <div><span id="notifySDT"></span></div>
            </div>

            <div class="CustomerInfo__Address">
                <h3>Địa chỉ<span>*</span></h3>
                <input type="text" id="txtDiaChi" name="txtDiaChi" placeholder="địa chỉ" class="inpText" onfocus="onfocusInput(this,notifyDiaChi)"/>
                <div><span id="notifyDiaChi"></span></div>
            </div>
        </div>
    </section>

    <section class="paymentMethod">
        <h2>Phương thức thanh toán</h2>
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


    <section class="Dondathang">
        <h2>Đơn hàng của bạn</h2>
        <section class="list_ProductSelected_container">
            <a href="ChiTietSanPham.aspx?pi=4"> <img src="../assest/images/Cho/sp-04.jpg" class="imgProduct"/></a>
            <div class="info">
                <a href="ChiTietSanPham.aspx?pi=4" style="color:black;"><h3 class="info__name">Sữa Tắm SOS Cho Chó Lông Trắng</h3></a>
                <div class="info__cost">
                    <div class="price">Giá:120000</div>
                    <div class="quantity">số lượng:1</div>
                    <div class="totalCostProduct">Tổng:120000</div>
                </div>
            </div>
        </section>
        <section class="cost">
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
    </section>
</body>
</html>
