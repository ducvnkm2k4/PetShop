using PetShop.model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;

namespace PetShop
{
    public class Code
    {
        public static string HienProducts(int num, string Type, List<Product> products)
        {
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
                    stringBuilder.AppendFormat("<a href='ChiTietSanPham.aspx?pi={2}' title='Xem {1}'><img src='{0}' alt='{1}' title='{1}' class='product-img'/>"
                   , item.Image
                   , item.Name
                   , item.Id
                   );
                    stringBuilder.AppendFormat("<div class='product-name'><a href='ChiTiet.aspx?pi={1}' title='Xem {0}'>{0}</a></div>"
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

        public static KeyValuePair<string, string> TaiKhoan(string customerName, string Url)
        {
            string taikhoan;
            string taikhoannavbar;
            if (customerName != "")
            {
                taikhoan = "Xin chào " + customerName +
                            "<span> | </span>" +
                            "<a href='DangNhap.aspx?request=dangxuat&preUrl=" + Url + "' style='color:white'>Đăng xuất </a>";
                taikhoannavbar =    "Xin chào " + customerName +
                                    "<span> | </span>" +
                                    "<a href='DangNhap.aspx?request=dangxuat&ru=" + Url + "' style='color:black' >Đăng xuất </a>";
            }
            else
            {
                taikhoan = "<a href='DangNhap.aspx?request=dangxuat&ru=" + Url + "' style='color:white' >Đăng nhập </a>" +
                            "<span> | </span>" +
                            "<a href='DangKy.aspx?request=dangxuat&ru=" + Url + "' style='color:white' >Đăng ký </a>";

                taikhoannavbar = "<a href='DangNhap.aspx?request=dangxuat&ru=" + Url + "' style='color:black' >Đăng nhập </a>" +
                                    "<span> | </span>" +
                                    "<a href='DangKy.aspx?request=dangxuat&ru=" + Url + "' style='color:black' >Đăng ký </a>";
            }
            return new KeyValuePair<string, string>(taikhoan, taikhoannavbar);
        }
    }
}