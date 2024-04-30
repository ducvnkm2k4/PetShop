using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PetShop.model;
using System.Text;
using System.Globalization;

namespace PetShop.web_pages
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //hiện danh sách sản phẩm
            List<Product> products = Application.Get(Global.LIST_PRODUCT) as List<Product>;
            product_list.InnerHtml = Code.HienProducts(12, "",products,"");

            //số lượng sản phẩm trong giỏ hàng
            numOfProduct.InnerHtml = "<p>" + (Session[Global.LIST_SHOPPING_CART] as List<CartItem>).Count + "</p>";

            //giao diện khi đã đăng nhập và chưa đăng nhập
            string customerName = Session[Global.CUSTOMER_NAME].ToString();
            KeyValuePair<string, string> pair = Code.TaiKhoan(customerName, Request.Url.AbsoluteUri);
            taikhoan.InnerHtml = pair.Key;
            taikhoannavbar.InnerHtml = pair.Value;
        }

    }
}