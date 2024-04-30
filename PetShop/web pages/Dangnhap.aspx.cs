using PetShop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShop.web_pages
{
    public partial class Danhnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //số lượng sản phẩm trong giỏ hàng
            numOfProduct.InnerHtml = "<p>" + (Session[Global.LIST_SHOPPING_CART] as List<CartItem>).Count + "</p>";

            //giao diện khi đã đăng nhập và chưa đăng nhập
            string customerName = Session[Global.CUSTOMER_NAME].ToString();
            KeyValuePair<string, string> pair = Code.TaiKhoan(customerName, Request.Url.AbsoluteUri);
            taikhoan.InnerHtml = pair.Key;
            taikhoannavbar.InnerHtml = pair.Value;

            //request
            string request = Request.QueryString["request"];
            string preUrl = Request.QueryString["preUrl"];
            //chức năng đăng nhập
            if (request =="dangxuat")
            {
                Session[Global.LIST_SHOPPING_CART] = new List<CartItem>();
                Session[Global.CUSTOMER_NAME] = "";
                Session[Global.CUSTOMER_ID] = "";
                Response.Redirect(preUrl);
                
            }
            //kiểm tra đăng nhập
            if (request == "check")
            {
                string gmail = Request.Form["txtGmail"];
                string password = Request.Form["txtPassword"];
                List<Customer> customers = Application.Get(Global.LIST_INFO_CUSTOMER) as List<Customer>;

                Customer customer = customers.Find(p => p.Email.Equals(gmail) && p.Password.Equals(password));

                if (customer != null)
                {//đăng nhập thành công
                    Session[Global.CUSTOMER_NAME] = customer.Name;
                    Session[Global.CUSTOMER_ID] = customer.Id;
                    Response.Redirect(preUrl);
                }
                else
                {//sai tên đăng nhập hoặc mật khẩu
                    txtGmail.Style["border"] = "1px solid red";
                    txtPassword.Style["border"] = "1px solid red";

                    notifyEmail.InnerText = "Sai tên đăng nhập hoặc mật khẩu";
                    notifyEmail.Style["color"] = "red";

                    notifyPassword.InnerText = "Sai tên đăng nhập hoặc mật khẩu";
                    notifyPassword.Style["color"] = "red";
                }
            }
        }
    }
}