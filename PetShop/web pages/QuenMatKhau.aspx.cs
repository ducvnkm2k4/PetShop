using PetShop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShop.web_pages
{
    public partial class QuenMatKhau : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            numOfProduct.InnerHtml = "<p>" + (Session[Global.LIST_SHOPPING_CART] as List<CartItem>).Count + "</p>";

            string customerName = Session[Global.CUSTOMER_NAME].ToString();
            Uri referrer = Request.UrlReferrer;
            string UrlRequest = referrer != null ? referrer.ToString() : string.Empty;
            KeyValuePair<string, string> pair = Code.TaiKhoan(customerName, UrlRequest);
            taikhoan.InnerHtml = pair.Key;
            taikhoannavbar.InnerHtml = pair.Value;
        }
    }
}