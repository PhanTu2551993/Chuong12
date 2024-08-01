namespace Chuong3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập bậc của đa thức (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhập giá trị của x: ");
            double x = double.Parse(Console.ReadLine());

            // Nhập hệ số cao nhất và khởi tạo giá trị của đa thức
            Console.Write($"Nhập hệ số a[{n}]: ");
            double result = double.Parse(Console.ReadLine());
    
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"Nhập hệ số a[{i}]: ");
                double coefficient = double.Parse(Console.ReadLine());
                result = result * x + coefficient;
            }

            Console.WriteLine($"Giá trị của đa thức P(x) tại x = {x} là: {result}");
        }
    }
}
