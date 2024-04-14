using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using PetShop.model;
using System.IO;
using Newtonsoft.Json;

namespace PetShop
{
    public class Global : System.Web.HttpApplication
    {
        public const string LIST_INFO_CUSTOMER = "ListInfoCustomer";
        public const string LIST_PRODUCT = "ListProduct";
        public const string LIST_SHOPPING_CART = "ListShoppingCart";
        public const string CUSTOMER_NAME = "";

        protected void Application_Start(object sender, EventArgs e)
        {
            Application[Global.LIST_INFO_CUSTOMER] = new List<Customer>
            {
                new Customer{Name="Hoàng anh",Email="anh@gmail.com",Password="anh123456",PhoneNumber="123456789",Address="Định công"},
                new Customer{Name="Việt anh",Email="Vanh@gmail.com",Password="Vanh123",PhoneNumber="123455612",Address="Định công"}

            };

            Application[Global.LIST_PRODUCT] = new List<Product> {
                new Product()
                {
                    Id="1",
                    Type="cho",
                    Image="../assest/images/Cho/sp-01.jpg",
                    Name="Thức Ăn Khô Cho Chó Con Smart Heart Gold Puppy 1kg",
                    Price=1115000,
                    Detail="Sản phẩm Thức Ăn Khô Cho Chó Con Smart Heart Gold Puppy 1kg là loại thức ăn hạt dành riêng cho chó nhỏ tầm dưới 12 tháng tuổi. Dòng sản phẩm SmartHeart đang ngày càng được ưa chuộng trong cộng đồng thú cưng vì hương vi thơm ngon, dễ ăn và được các bé cún yêu thích."
                },

                new Product()
                {
                    Id="2",
                    Type="cho",
                    Image="../assest/images/Cho/sp-02.jpg",
                    Name = "Sữa Bột Predogen cho chó hộp 110g",
                    Price = 42000,
                    Detail = "Sữa bột dành cho chó PREDOGEN được sản xuất theo công thức của WONDERLIFE PHARMA  (mỹ) là một thực phẩm bổ dưỡng cho chó yêu của bạn ngoài những thức ăn thông thường, giúp chó yêu cảm thấy ngon miệng hơn, bồi bổ cơ thể và cung cấp những thứ cần thiết để phát triển toàn diện."
                 },
                new Product()
                {
                    Id="3",
                    Type="cho",
                    Image="../assest/images/Cho/sp-03.png",
                    Name = "Dụng Cụ Lấy Lông Chó Mèo Bám Dính",
                    Price = 145000,
                    Detail = "Dụng Cụ Lấy Lông Chó Mèo Bám Dính được làm từ nhựa ABS. Nhựa ABS là loại nhựa có độ cứng, độ bền cực cao. Sản phẩm có khả năng chịu lực tốt, không dễ bị trày xước. Đặc biệt, loại nhựa này hoàn toàn đảm bảo an toàn cho người sử dụng, không mùi, không chất hoá học."
               },
                new Product()
                {
                    Id="4",
                    Type="cho",
                    Image="../assest/images/Cho/sp-04.jpg",
                    Name = "Sữa Tắm SOS Cho Chó Lông Trắng",
                    Price = 120000,
                    Detail = "Sữa Tắm SOS Cho Chó Lông Trắng màu xanh ngọc dành riêng cho chó có lông màu trắng. Có tác dụng làm mềm mượt lông, phục hồi hư tổn đối với thú cưng có bộ lông bị khô, xơ trở nên bóng, khỏe, trắng hơn và không bị bạc màu."
                 },
                new Product()
                {
                    Id="5",
                    Type="cho",
                    Image="../assest/images/Cho/sp-05.jpg",
                    Name = "Áo Mùa Hè Teddy Sọc Cho Chó",
                    Price = 85000,
                    Detail = "Áo Mùa Hè Teddy Sọc Cho Chó Mèo được làm từ những chất liệu vải khô thoáng nhất. Chủ yếu là từ vải cotton giúp thấm mồ hôi hiệu quả. Đồng thời, trong những ngày thời tiết mùa hè thì sản phẩm này sẽ giúp trao đổi không khí, khiến thú cưng thấy dễ chịu, mát mẻ hơn."
                },
                new Product()
                {
                    Id="6",
                    Type="cho",
                    Image="../assest/images/Cho/sp-06.jpg",
                    Name="Thức Ăn Khô Cho Chó Con Smart Heart Gold Puppy 1kg",
                    Price=1115000,
                    Detail="Sản phẩm Thức Ăn Khô Cho Chó Con Smart Heart Gold Puppy 1kg là loại thức ăn hạt dành riêng cho chó nhỏ tầm dưới 12 tháng tuổi. Dòng sản phẩm SmartHeart đang ngày càng được ưa chuộng trong cộng đồng thú cưng vì hương vi thơm ngon, dễ ăn và được các bé cún yêu thích."
                },
                new Product()
                {
                    Id="7",
                    Type="cho",
                    Image="../assest/images/Cho/sp-07.jpg",
                    Name = "Khay vệ sinh vuông cho chó thành cao có cọc",
                    Price = 170000,
                    Detail = "Khay vệ sinh cho chó được thiết kế dành riêng cho chó đi vệ sinh, nên hộp đi vệ sinh cho bên mình nhập về có kiểu dáng bắt mắt, chất lượng nhựa bền, đẹp. Đối tượng: phù hợp với các dòng chó như Pomeranian, Binchon, pooder, minpincher … vv."
                 },
                new Product()
                {
                    Id="8",
                    Type="cho",
                    Image="../assest/images/Cho/sp-08.jpg",
                    Name = "Lồng Đen Cao Cấp Cho Chó",
                    Price = 690000,
                    Detail = "Sản phẩm Lồng Đen Cao Cấp Cho Chó là một sản phẩm hữu ích và tiện lợi. Với Lồng Đen Cao Cấp Cho Chó bạn có thể dễ dàng kiểm soát cún cưng. Với sự tiện lợi và an toàn, lồng đen cao cấp là sự lựa chọn yêu thích của nhiều chủ nhân nuôi thú cưng."
                },
                new Product()
                {
                    Id="9",
                    Type="cho",
                    Image="../assest/images/Cho/sp-09.jpg",
                    Name = "Vòng Cổ 1.5cm Cho Chó",
                    Price = 18000,
                    Detail = "Vòng cổ cho chó với thiết kế dày dặn và chắc chắn. Chiếc vòng cổ này sẽ nằm thật gọn gàng trên cổ thú cưng khiến chúng vô cùng đáng yêu. Vòng Cổ 1.5cm Cho Chó sẽ là một công cụ đắc lực cho bạn. Nó giúp bạn dễ dàng quản lý chú chó nghịch ngợm của mình hơn."
               },
                new Product()
                {
                    Id="10",
                    Type="cho",
                    Image="../assest/images/Cho/sp-10.jpg",
                    Name = "Kính Thời Trang Cho Thú Cưng",
                    Price = 35000,
                    Detail = "Sản phẩm Kính Thời Trang Cho Thú Cưng được làm từ những chất liệu an toàn với thú cưng. Chất liệu chủ yếu là nhựa tự nhiên, không độc hại cho thú cưng. Đồng thời, chất liệu nhựa có độ bền cực cao, chịu va đập tốt. Trời chuyển hè, những tia nắng gắt có thể chiếu vào mắt các bạn thú cưng. Vì vậy hãy bảo vệ đôi mắt của các bé bằng cách đeo Kính Thời Trang Cho Thú Cưng."
                },
                new Product()
                {
                    Id="11",
                    Type="meo",
                    Image="../assest/images/meo/sp-11.jpg",
                    Name = "Sữa Bột Precaten cho mèo hộp 110g",
                    Price = 42000,
                    Detail = "Sữa bột dành cho Mèo PRECATEN được sản xuất theo công thức của WONDERLIFE PHARMA (Mỹ) là một thực phẩm bổ dưỡng cho mèo yêu của bạn. ngoài những thức ăn thông thường, sữa giúp bé mèo cảm thấy ngon miệng hơn, bồi bổ cơ thể và cung cấp những thứ cần thiết để phát triển toàn diện."
                 },
                new Product()
                {
                    Id="12",
                    Type="meo",
                    Image="../assest/images/meo/sp-12.jpg",
                    Name = "Thức Ăn Khô Cho Mèo Cat Eye 1.5kg",
                    Price = 150000,
                    Detail = "Thức Ăn Khô Cho Mèo Cat Eye 1.5Kg được phối trộn đặc biệt dành cho mèo mọi lứa tuổi để giảm chứng rụng lông, cải thiện bộ lông mèo và cải thiện tiêu hóa. Với những thành phần dễ tiêu hóa và cực kỳ ngon miệng sẽ giúp tăng cường hệ thống miễn dịch, cải thiện khả năng hấp thụ dinh dưỡng, tăng cường sức khỏe đại tràng và giảm lãng phí thức ăn ăn vào của mèo."
                },
                new Product()
                {
                    Id="13",
                    Type="meo",
                    Image="../assest/images/meo/sp-13.jpg",
                    Name = "Bánh Thưởng Dạng Kem Vị Cá Hồi Me-O",
                    Price = 45000,
                    Detail = "Sản phẩm Bánh Thưởng Dạng Kem Me-O Vị Cá Hồi là kết quả của các chuyên gia đến từ Thái Lan. Được nhập khẩu tại Thái Lan, với chất lượng an toàn. Đây là 1 dòng sản phẩm thuộc thương hiệu Me-O rất quen thuộc với chúng ta rồi! Me-O là thương hiệu có nguồn gốc từ Thái Lan, chuyên sản xuất các sản phẩm dành cho mèo."
                },
                new Product()
                {
                    Id="14",
                    Type="meo",
                    Image="../assest/images/meo/sp-14.jpg",
                    Name = "Đồ Chơi Đèn Tia Laser Cho Mèo",
                    Price = 25000,
                    Detail = "Đồ Chơi Đèn Tia Laser Cho Mèo được làm từ hợp kim không gỉ, đảm bảo rất an toàn với người sử dụng. Các chất liệu để làm ra sản phẩm đều đã được kiểm nghiệm kỹ lưỡng. Bạn hoàn toàn có thể an tâm về chất lượng của sản phẩm này khi mua cho mèo nhà mình."
                 },
                new Product()
                {
                    Id="15",
                    Type="meo",
                    Image="../assest/images/meo/sp-15.jpg",
                    Name = "Xịt Khử Mùi Dưỡng Lông Budle Budle Cho Chó Mèo",
                    Price = 150000,
                    Detail = "Với công dụng chính là khử mùi của chó mèo, Xịt Khử Mùi Dưỡng Lông Budle Budle Cho Chó Mèo có thể dùng để khử mùi nơi ngủ và các vật dụng khác của thú cưng. Hơn nữa còn có tác dụng khử trùng, kháng khuẩn, loại bỏ hoàn toàn các vi khuẩn, nấm hay ký sinh gây hai."
               },
                new Product()
                {
                    Id="16",
                    Type="meo",
                    Image="../assest/images/meo/sp-16.jpg",
                    Name = "Bát Thép Không Gỉ Gắn Chuồng Cho Chó Mèo",
                    Price=65000,
                    Detail = "Bát Thép Không Gỉ Gắn Chuồng Cho Chó Mèo được thiết kế hết sức tinh xảo. Điểm nổi bật chính là phần khoá xoay được làm chắc chắn, giúp cố định bát ở chuồng. Bên cạnh đó, lòng bát để đựng thức ăn có độ sâu vừa đủ, giúp chó mèo ăn dễ dàng hơn."
                },
                new Product()
                {
                    Id="17",
                    Type="meo",
                    Image="../assest/images/meo/sp-17.jpg",
                    Name = "Nhà Đệm Có Mái Cửa Vuông Màu Vàng",
                    Price=233000,
                    Detail = "Nhà Đệm Có Mái Cửa Vuông Màu Vàng cho thú cưng chất liệu mềm mại. Mái nhà cũng làm bằng đệm lớp vải sọc kẻ rất đặc biệt. Bên trong có lót đệm dễ dàng vệ sinh. Lót đệm êm sẽ giúp thú cưng ngủ thoải mái hơn. Mùa đông cũng sẽ ấm áp hơn rất nhiều đấy ạ!!."
                },
                new Product()
                {
                    Id="18",
                    Type="meo",
                    Image="../assest/images/meo/sp-18.jpg",
                    Name = "Khay Vệ Sinh Cho Mèo",
                    Price=116000,
                    Detail = "Khay Vệ Sinh Cho Mèo làm bằng nhựa cứng cao cấp, bền chắc, an toàn cho thú cưng. Xung quanh có viền bao giống như một nhà vệ sinh thu nhỏ cho mèo nhà bạn. Các chất liệu nhựa được sử dụng đều an toàn, dễ dàng chùi rửa. Đảm bảo không để lại những vết bẩn."
                },
                new Product()
                {
                    Id="19",
                    Type="meo",
                    Image="../assest/images/meo/sp-19.jpg",
                    Name = "Yếm teddy kèm túi và dây dắt cho mèo",
                    Price=140000,
                    Detail = "Yếm teddy kèm túi và dây dắt cho chó mèo sẽ là sự lựa chọn rất tốt cho bạn. Sản phẩm không làm đau mà lại dễ dàng giúp bạn quản lý thú cưng hơn. Yếm kèm 1 túi nhỏ rất tiện dụng cho các bạn đựng tiền hoặc các đồ dùng nhỏ gọn."
                },
                new Product()
                {
                    Id="20",
                    Type="meo",
                    Image="../assest/images/meo/sp-20.jpg",
                    Name = "Đồ Chơi Con Rối Âm Thanh Cho Thú Cưng",
                    Price=45000,
                    Detail = "Đồ Chơi Con Rối Âm Thanh Cho Thú Cưng là đồ chơi không thể thiếu cho thú cưng của bạn. Món đồ chơi này sẽ giúp các bạn thú cưng không còn cắn xé đồ vật trong nhà nữa. Thậm chí còn giúp chúng vận động linh hoạt hơn. Sản phẩm được làm từ những chất liệu an toàn với thú cưng.Đảm bảo không ảnh hưởng tới sức khoẻ của các bé."
                },
            };
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session[Global.LIST_SHOPPING_CART] = new List<CartItem>();
            Session[Global.CUSTOMER_NAME] = "";
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
          
        }

        protected void Application_End(object sender, EventArgs e)
        {
            
        }
    }
}