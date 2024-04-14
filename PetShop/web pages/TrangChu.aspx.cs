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
            numOfProduct.InnerHtml = "<p>" + LaySoLuongSanPhamTrongGioHang() + "</p>";
            TaiKhoan();
        }

        public int LaySoLuongSanPhamTrongGioHang()
        { 
            List<Product> products = Application.Get(Global.LIST_PRODUCT) as List<Product>;
            return products.Count;
        }
        public void TaiKhoan()
        {
            if(Session[Global.CUSTOMER_NAME].ToString() == "")
            {
                taikhoan.InnerHtml =
                    "Xin chào " + Session[Global.CUSTOMER_NAME].ToString() +
                    "<span> | </span>" +
                    "<a href='DangNhap.aspx?DangXuat=true&ru=" + Request.UrlReferrer + "'>Đăng xuất </a>";
            }
            else
            {
                taikhoan.InnerHtml =
                    "<a href='DangNhap.aspx?dangxuat=false&ru=" + Request.UrlReferrer + "'>Đăng nhập </a>" +
                    "<span> | </span>" +
                    "<a href='DangKy.aspx'>Đăng ký </a>";
            }
        }
        public string HienProducts(int basedIndex, int lasIndex)
        {
            List<Product> products = Application.Get(Global.LIST_PRODUCT) as List<Product>;
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = basedIndex; i < lasIndex; i++)
            {
                Product item = products[i] as Product;
                stringBuilder.Append("<div class='grid product"+i+"'>");
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
                stringBuilder.AppendFormat("<div class='product-price' id='product-price' >{0}</div>"
                    , item.Price.ToString("#,0", new CultureInfo("vi-VN")) + " ₫");
                stringBuilder.Append("</div>");
            }
            return stringBuilder.ToString();
        }
    }
}