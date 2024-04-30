using Newtonsoft.Json;
using PetShop.model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShop.web_pages
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = Application.Get(Global.LIST_PRODUCT) as List<Product>;

            //số lượng sản phẩm trong giỏ hàng
            numOfProduct.InnerHtml = "<p>" + (Session[Global.LIST_SHOPPING_CART] as List<CartItem>).Count + "</p>";

            //giao diện khi đã đăng nhập và chưa đăng nhập
            string customerName = Session[Global.CUSTOMER_NAME].ToString();
            KeyValuePair<string, string> pair = Code.TaiKhoan(customerName, Request.Url.AbsoluteUri);
            taikhoan.InnerHtml = pair.Key;
            taikhoannavbar.InnerHtml = pair.Value;

            //thông tin sản phẩm
            string ID = Request.QueryString["pi"];
            string request = Request.QueryString["request"];
            if (ID != null)
            {
                Product product = products.Find(p => p.Id.Equals(ID));
                product_name.InnerText = product.Name;
                product_image.InnerHtml = "<img src='" + product.Image + "' alt='Hình ảnh" + product.Name + "' title='" + product.Name + "' class='product_image'/>";
                product_price.InnerText = product.Price.ToString("#,0", new CultureInfo("vi-VN")) + " ₫";
                product_detail.InnerText = product.Detail;
            }
        }

        //thêm sản phẩm vào giỏ hàng
        protected void btnAdd_click(object sender,EventArgs eventArgs)
        {
            string ID = Request.QueryString["pi"];
            List<Product> products = Application.Get(Global.LIST_PRODUCT) as List<Product>;
            List<CartItem> cartItems = Session[Global.LIST_SHOPPING_CART] as List<CartItem>;
            Product product = products.Find(p => p.Id.Equals(ID));
            CartItem cartItem = cartItems.Find(ci => ci.Id.Equals(ID));

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Detail = product.Detail,
                    Type = product.Type,
                    Image = product.Image,
                    Quantity = 1
                };
                cartItems.Add(cartItem);
                Session[Global.LIST_SHOPPING_CART] = cartItems;
            }
            else
            {
                cartItems.Remove(cartItem);
                cartItem.Quantity += 1;
                cartItems.Add(cartItem);
                Session[Global.LIST_SHOPPING_CART] = cartItems;
            }
            Response.Redirect(Request.UrlReferrer.ToString());
        }
    }
}