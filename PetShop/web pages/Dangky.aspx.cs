using PetShop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShop.web_pages
{
    public partial class Dangky : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            numOfProduct.InnerHtml = "<p>" + (Session[Global.LIST_SHOPPING_CART] as List<CartItem>).Count + "</p>";

            string customerName = Session[Global.CUSTOMER_NAME].ToString();
            KeyValuePair<string, string> pair = Code.TaiKhoan(customerName, Request.Url.AbsoluteUri);

            taikhoan.InnerHtml = pair.Key;
            taikhoannavbar.InnerHtml = pair.Value;


            string preurl = Request.QueryString["preUrl"];
            string request = Request.QueryString["request"];
            if (request == "submit")
            {
                List<Customer> customers = Application.Get(Global.LIST_INFO_CUSTOMER) as List<Customer>;
                Customer customer = new Customer();

                customer.Name = Request.Form["txtName"];
                customer.Email = Request.Form["txtgmail"];
                customer.PhoneNumber = Request.Form["txtSDT"];
                customer.Address = Request.Form["txtDiaChi"];
                customer.Password = Request.Form["txtPassword"];
               
                customers.Add(customer);
                Application[Global.LIST_INFO_CUSTOMER] = customers;
                Session[Global.CUSTOMER_NAME] = Request.Form["txtName"];

                Response.Redirect(preurl);
            }
        }
    }
}