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
    public partial class SanPhamCho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            TaiKhoan();
            numOfProduct.InnerHtml ="<p>"+LaySoLuongSanPhamTrongGioHang() +"</p>";
            product_list.InnerHtml = HienProducts(10, "cho");
        }
        public int LaySoLuongSanPhamTrongGioHang()
        {
            List<CartItem> listCartItems = Session[Global.LIST_SHOPPING_CART] as List<CartItem>;
            return listCartItems.Count;
        }
        public void TaiKhoan()
        {
            if (Session[Global.CUSTOMER_NAME].ToString() != "")
            {
                taikhoan.InnerHtml =
                    "Xin chào " + Session[Global.CUSTOMER_NAME].ToString() +
                    "<span> | </span>" +
                    "<a href='DangNhap.aspx?DangXuat=true&ru=" + Request.UrlReferrer + "' style='color:white'>Đăng xuất </a>";
                taikhoannavbar.InnerHtml =
                    "Xin chào " + Session[Global.CUSTOMER_NAME].ToString() +
                    "<span> | </span>" +
                    "<a href='DangNhap.aspx?DangXuat=true&ru=" + Request.UrlReferrer + "' style='color:black'>Đăng xuất </a>";
            }
            else
            {
                taikhoan.InnerHtml =
                    "<a href='DangNhap.aspx?dangxuat=false&ru=" + Request.UrlReferrer + "' style='color:white' >Đăng nhập </a>" +
                    "<span> | </span>" +
                    "<a href='DangKy.aspx' style='color:white' >Đăng ký </a>";
                taikhoannavbar.InnerHtml =
                    "<a href='DangNhap.aspx?dangxuat=false&ru=" + Request.UrlReferrer + "' style='color:black' >Đăng nhập </a>" +
                    "<span> | </span>" +
                    "<a href='DangKy.aspx' style='color:black' >Đăng ký </a>";
            }
        }
        public string HienProducts(int num, string Type)
        {
            List<Product> products = Application.Get(Global.LIST_PRODUCT) as List<Product>;
            StringBuilder stringBuilder = new StringBuilder();
            if (num > products.Count)
            {
                num = products.Count;
            }
            int temp = 1;
            foreach (Product item in products)
            {
                if (num == 0) break;

                if (Type == "" || item.Type.Equals(Type))
                {
                    num--;
                    stringBuilder.Append("<div class='product product" + temp++ + "'>");
                    stringBuilder.AppendFormat("<a href='/ChiTiet.aspx?pi={2}' title='Xem {1}'><img src='{0}' alt='{1}' title='{1}' class='product-img'/>"
                   , item.Image
                   , item.Name
                   , item.Id
                   );
                    stringBuilder.AppendFormat("<div class='product-name'><a href='/ChiTiet.aspx?pi={1}' title='Xem {0}'>{0}</a></div>"
                        , item.Name
                        , item.Id
                        );
                    stringBuilder.Append("</a>");
                    stringBuilder.AppendFormat("<div class='product-price' >{0}</div>"
                        , item.Price.ToString("#,0", new CultureInfo("vi-VN")) + " ₫");
                    stringBuilder.Append("</div>");
                }
            }
            return stringBuilder.ToString();
        }
    }
}