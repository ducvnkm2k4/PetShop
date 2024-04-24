using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PetShop.model;
namespace PetShop.web_pages
{
    public partial class ThanhToanDonHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string customerId = Session[Global.CUSTOMER_ID].ToString();
            List<Customer> customers = Application.Get(Global.LIST_INFO_CUSTOMER) as List<Customer>;
            /////thông tin khách hàng
            if (!string.IsNullOrEmpty(customerId))
            {
                title_login.Style["display"] = "none";
                Customer customer = customers.Find(c => c.Id.ToString().Equals(customerId));
                txtName.Value = customer.Name;
                txtDiaChi.Value = customer.Address;
                txtGmail.Value = customer.Email;
                txtSDT.Value = customer.PhoneNumber;
            }
            else
            {
                title_login.Style["display"] = "block";
                txtName.Value = null;
                txtDiaChi.Value =null;
                txtGmail.Value = null;
                txtSDT.Value = null;
            }
            /////danh sách sản phẩm
            StringBuilder sb = new StringBuilder();
            List<CartItem> cartItems = Session[Global.LIST_SHOPPING_CART] as List<CartItem>;
            long totalCost = 0;
            foreach(CartItem cartItem in cartItems)
            {
                totalCost += cartItem.Quantity * cartItem.Price;
                sb.Append("<div class='cartitem' style='display: flex; '>");
                sb.AppendFormat("<img src='{0}' class='imgProduct' style='margin-right: 15px'/>", cartItem.Image);
                sb.Append("<div class='infor_CartItem'>");
                sb.AppendFormat("<h3 class='info__name'>{0}</h3>", cartItem.Name);
                sb.AppendFormat("<div class='price'>Giá:{0}</div>", cartItem.Price.ToString("#,0", new CultureInfo("vi-VN")) + " ₫");
                sb.AppendFormat("<div class='quantity'>số lượng:{0}</div>", cartItem.Quantity);
                sb.AppendFormat("<div class='totalCostProduct'>Tổng:{0}</div>", (cartItem.Quantity * cartItem.Price).ToString("#,0", new CultureInfo("vi-VN")) + " ₫");
                sb.Append("</div>");
                sb.Append("</div>");
            }
            cartItem_container.InnerHtml = sb.ToString();
            totalCostElement.InnerText = totalCost.ToString("#,0", new CultureInfo("vi-VN")) + " ₫";
        }

        protected void btnDatHang_Click(object sender, EventArgs eventArgs)
        {
            Session[Global.LIST_SHOPPING_CART] = new List<CartItem>();
            Response.Redirect("TrangChu.aspx");
        }
    }
}