namespace _3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập một số tự nhiên n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Các số nguyên tố không lớn hơn {n} là: ");

            // Vòng lặp từ 2 đến n
            for (int num = 2; num <= n; num++)
            {
                bool isPrime = true;
                // Kiểm tra xem num có phải là số nguyên tố không
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                // Nếu num là số nguyên tố
                if (isPrime)
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }
    }
}
