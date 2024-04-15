﻿using PetShop.model;
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
    public partial class SanPhamCho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = Application.Get(Global.LIST_PRODUCT) as List<Product>;
            product_list.InnerHtml = Code.HienProducts(12, "cho", products);


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