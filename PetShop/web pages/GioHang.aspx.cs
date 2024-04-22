using PetShop.model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShop.web_pages
{
    public partial class GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            numOfProduct.InnerHtml = "<p>" + (Session[Global.LIST_SHOPPING_CART] as List<CartItem>).Count + "</p>";

            string customerName = Session[Global.CUSTOMER_NAME].ToString();

            KeyValuePair<string, string> pair = Code.TaiKhoan(customerName, Request.Url.AbsoluteUri);
            taikhoan.InnerHtml = pair.Key;
            taikhoannavbar.InnerHtml = pair.Value;


            List<CartItem> cartItems = Session[Global.LIST_SHOPPING_CART] as List<CartItem>;

            StringBuilder sb = new StringBuilder();
            long total = 0;
            foreach (CartItem cartItem in cartItems)
            {
                total += cartItem.Price * cartItem.Quantity;
                sb.Append("<div class='sp''>");
                sb.AppendFormat("<a href='ChiTietSanPham.aspx ? pi = {0}'> <img src='{1}' class='imgProduct'/></a>", cartItem.Id, cartItem.Image);
                sb.Append("<div class='info''>");
                sb.AppendFormat("<a href='ChiTietSanPham.aspx ? pi = {0}' style='color: black; ' ><h3 class='info__name'>{1}</h3></a>", cartItem.Id, cartItem.Name);
                sb.Append("<div class='info__cost'>");
                sb.AppendFormat("<div class='price'>Giá:{0}</div>", cartItem.Price.ToString("#,0", new CultureInfo("vi-VN")) + " ₫");
                sb.Append("<div>");
                sb.AppendFormat("<a href='GioHang.aspx?request=minus&id={0}'>", cartItem.Id);
                sb.Append("<i class='fa-solid fa-minus'></i>");
                sb.Append("</a>");
                sb.AppendFormat("<input type='text' id='quantity{0}' class='quantity' value='{1}' />", cartItem.Id, cartItem.Quantity);
                sb.AppendFormat("<a href='GioHang.aspx?request=plus&id={0}'>", cartItem.Id);
                sb.Append("<i class='fa-solid fa-plus'></i>");
                sb.Append("</a>");
                sb.Append("</div>");
                sb.AppendFormat("<div class='totalCostProduct'>Tổng:{0}</div>", (cartItem.Price * cartItem.Quantity).ToString("#,0", new CultureInfo("vi-VN")) + " ₫");
                sb.Append("<i class='ti-trash' style='cursor: pointer;'></i>");
                sb.Append("</div>");
                sb.Append("</div>");
                sb.Append("</div>");
            }
            if (total == 0)
            {
                main_content.InnerHtml = "<img src='../assest/images/gio_hang_trong.png' alt='Giỏ hàng của bạn hiện đang trống' class='empty_cart_img'/>";
            }
            else
            {
                Container_cart.InnerHtml = sb.ToString();
                totalCost.InnerText = total.ToString("#,0", new CultureInfo("vi-VN")) + " ₫";

            }


            string request = Request.QueryString["request"];
            string idRequest = Request.QueryString["id"];
            int index=-1;
            if (!string.IsNullOrEmpty(idRequest))
            {
                index = cartItems.IndexOf(cartItems.Find(ct => ct.Id.Equals(idRequest)));

            }
            if (!string.IsNullOrEmpty(request)&&request.Equals("plus"))
            {
                if(index!=-1)
                    cartItems[index].Quantity += 1;
                Session[Global.LIST_SHOPPING_CART] = cartItems;
                Response.Redirect("GioHang.aspx");
            }

            if (!string.IsNullOrEmpty(request) && request.Equals("minus"))
            {
                if(index!=-1)
                    cartItems[index].Quantity -= 1;
                if (cartItems[index].Quantity == 0) cartItems.Remove(cartItems[index]);
                Session[Global.LIST_SHOPPING_CART] = cartItems;
                Response.Redirect("GioHang.aspx");
            }
        }


    }
    
}