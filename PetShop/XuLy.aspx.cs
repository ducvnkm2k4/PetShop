using PetShop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShop
{
    public partial class XuLy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static void AddToCart(string cartItemsJson)
        {
            // Chuyển đổi chuỗi JSON thành danh sách đối tượng
            List<CartItem> cartItems = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CartItem>>(cartItemsJson);

            // Lưu danh sách vào session
            HttpContext.Current.Session[Global.LIST_SHOPPING_CART] = cartItems;
        }
    }
}