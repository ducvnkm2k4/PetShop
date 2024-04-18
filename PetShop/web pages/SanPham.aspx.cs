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
    public partial class SanPhamMeo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Product> products = Application.Get(Global.LIST_PRODUCT) as List<Product>;
            string type = Request.QueryString["type"];

            product_list.InnerHtml = Code.HienProducts(12, type, products,"");


            numOfProduct.InnerHtml = "<p>" + (Session[Global.LIST_SHOPPING_CART] as List<CartItem>).Count + "</p>";

            string customerName = Session[Global.CUSTOMER_NAME].ToString();

            KeyValuePair<string, string> pair = Code.TaiKhoan(customerName, Request.Url.AbsoluteUri);

            taikhoan.InnerHtml = pair.Key;
            taikhoannavbar.InnerHtml = pair.Value;


            switch (type)
            {
                case "cho":
                    title.InnerText = "Sản phẩm cho chó";
                    hd_cho.Style["color"] = "#FA8072;";
                    break;
                case "meo":
                    title.InnerText = "sản phẩm cho mèo";
                    hd_meo.Style["color"] = "#FA8072;";
                    break;
                case "search":
                    string key = Request.QueryString["key"];
                    product_list.InnerHtml = Code.HienProducts(12, type, products, key);
                    banner.Style["display"] = "none";
                    title.InnerText = "Danh sách sản phẩm tìm thấy";
                    break;

            }
        }
    }
}