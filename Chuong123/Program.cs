namespace Chuong123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chương 1 :
            //1.Nền tảng.NET Framework là gì?
            /*
            Là môi trường đa ngôn ngữ để xây dựng, triển khai và chạy các ứng dụng do hãng Microsoft phát triển.
            .NET Framework cho phép phát triển các ứng dụng chạy trên nhiều môi trường khác nhau như thiết bị
            di động, máy tính để bàn, điện thoại thông minh, dịch vụ web…
            .NET Framework là thành phần được cài đặt sẵn khi cài đặt hệ điều hành windows. Nếu hệ điều hành
            nào chưa có.NET Framework cài sẵn thì bạn hoàn toàn có thể tự cài đặt thêm.
            */

            //2.Các công nghệ cốt lõi sử dụng trong.NET Framework là gì? 
            // Microsoft Intermediate Language , Common Language Runtime

            //3.  Liệt kê ra các thành phần của .NET Framework?

            /*
             - Các ngôn ngữ lập trình
             - Thư viện các lớp(Framework Class Library - FCL)
             - The Common Language Runtime(CLR)
             */

            // 4. .NET Framework hỗ trợ ngôn ngữ lập trình C/C++?
            // có hỗ trợ 

            //5.Có thể dùng ngôn ngữ C# viết các chương trình chạy trên các thiết bị di động?
            // có thể 

            //6. Mục đích của Common Language Runtime là gì?
            // biên  dịch ngôn ngữ trung gian sang ngôn ngữ máy.

            //7. ____________thực hiện các chức năng quản lý bộ nhớ, xử lý lỗi, dọn dẹp bộ nhớ?
            //  Common Language Runtime 

            //8. ____________cung cấp một tập các lớp để làm việc với cơ sở dữ liệu?
            //-Entity Framework
            // - ADO.NET
            // - Dapper

            //9. ____________cung cấp một tập các lớp để thiết kế các Form cho các trang web giống như Form HMTL?
            //- ASP.NET Web Forms
            //-ASP.NET MVC
            //- Razor Pages

            //10. ___________được sử dụng như là công cụ để phát triển các ứng dụng cho máy để bàn, dịch vụ web, ứng dụng mobile ứng dụng web có hiệu suất cao?
            // - Visual Studio

            //11. Trong một ứng dụng có thể có bao nhiêu phương thức Main?
            // có 1 phương thức Main 

            //12. Chương trình C# sẽ bắt ñầu thực thi từ đâu ?
            // từ phương thức Main 


            //Chương 2

            //1. Sau khi viết xong chương trình bằng C#, nếu copy tệp tin *.exe đã viết sang máy khác để chạy,
            //   chương trình ñó có chạy không? Giải thích.
            // chương trình có chạy. 
            // Sau khi biên dịch lần đầu tiên chạy chương trình, ngôn ngữ MSIL sẽ được biên dịch sang ngôn ngữ máy 
            // Quá trình chuyển ñổi từ MSIL sang ngôn ngữ máy lúc thực thi chương trình được thực hiện bởi
            // thành phần Just – in – time compiler nằm trong CLR(Common Language Runtime). 
            //CLR là một máy ảo của .NET nó ñược dùng để chuyển đổi mã MSIL sang mã máy. Sau đó các
            // đoạn mã được thực thi bởi CPU.

            // 2. Kí tự đầu tiên của tên biến có thể là kí số ? 
            // Không, ký tự đầu tiên của tên biến không thể là ký số. Tên biến phải bắt đầu bằng một chữ cái hoặc dấu gạch dưới (`_`).
            // Các ký tự tiếp theo có thể là chữ cái, ký số hoặc dấu gạch dưới.

            //3 Tên biến có thể là từ khóa ? 
            // Tên biến không đươc trùng với từ khóa. Nếu muốn sử dụng là từ khóa phải thêm @ trước tên biến

            // 4.Lớp Console thuộc vào namespace nào ?
            // Lớp Console thuộc namespace System 


            //5.Viết chương trình tính diện tích và chu vi hình chữ nhật.

            //Console.WriteLine("Nhập chiều dài");
            //double lenght = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Nhập chiều rộng");
            //double width = Convert.ToDouble(Console.ReadLine());

            //double area = lenght*width;
            //double perimeter = (lenght+width)*2;
            //Console.WriteLine("Diện tích HCN là :" + area);
            //Console.WriteLine("Chu vi HCN là : {0:F2}",perimeter);

            //6 Viết chương trình tính thể tích của một hình trụ (V = 3,14.r2.h)

            //Console.WriteLine("Nhập bán kính :");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Nhập chiều cao hình trụ :");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double volume = Math.PI * radius * radius * height;
            //Console.WriteLine("Thể tích hình trụ là :{0:F2}",volume);

            // 7  Viết chương trình tính lương thực lãnh của một nhân viên theo công thưc dưới đây :
            Console.WriteLine("Nhap luong co ban");
            double luongCoBan = Convert.ToDouble(Console.ReadLine());
            double bhyt = 0.12 * luongCoBan;
            double bhxh = 150;
            double cd = 120;
            double thue = 0.14 * luongCoBan;

            double luongThucLanh = luongCoBan - bhyt - bhxh - cd - thue;

            Console.WriteLine("Luong co ban: " + luongCoBan);
            Console.WriteLine("BHYT: " + bhyt);
            Console.WriteLine("BHXH: " + bhxh);
            Console.WriteLine("CD: " + cd);
            Console.WriteLine("Thue: " + thue);
            Console.WriteLine("Luong thuc lanh: " + luongThucLanh);
        }
    }
}
