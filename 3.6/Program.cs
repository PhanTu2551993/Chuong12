namespace _3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập giá trị c (ví dụ c = 0.0001): ");
            double c = double.Parse(Console.ReadLine());
            if (c <= 0)
            {
                Console.WriteLine("Giá trị c phải lớn hơn 0.");
                return;
            }

            Console.Write("Nhập giá trị x: ");
            double x = double.Parse(Console.ReadLine());

            double result = 1.0; 
            double term = 1.0; 
            int n = 1; 

            while (true)
            {
                term *= x / n;

                if (Math.Abs(term) <= c)
                {
                    break; 
                }

                result += term;
                n++;
            }
            Console.WriteLine($"Giá trị gần đúng của e^{x} là: {result}");
            Console.WriteLine($"Số hạng cuối cùng là: {term}");
            Console.WriteLine($"Số lượng số hạng đã tính: {n}");
        }
    }
}
