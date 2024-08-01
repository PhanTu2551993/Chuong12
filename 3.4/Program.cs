namespace _3._4
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

            double pi = 0.0;
            double term;
            int n = 0;
            while (true)
            {
                term = 4.0 * ((n % 2 == 0 ? 1.0 : -1.0) / (2.0 * n + 1.0));
                pi += term;

                if (1.0 / (2.0 * n + 1.0) <= c)
                {
                    break;
                }

                n++;
            }

            Console.WriteLine($"Giá trị π gần đúng là: {pi}");
            Console.WriteLine($"Số hạng cuối cùng là: {term}");
            Console.WriteLine($"Số lượng số hạng đã tính: {n}");
        }
    }
}
