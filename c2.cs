using System;

class Program
{
    static void Main()
    {
        Console.Write("عدد x را بر حسب درجه وارد کنید: ");
        double degree = double.Parse(Console.ReadLine());

        // تبدیل درجه به رادیان
        double x = degree * Math.PI / 180.0;

        // تعداد جمله‌هایی که در بسط تیلور استفاده می‌کنیم (مثلاً 10 جمله)
        int n = 10;
        double cosX = 0;

        for (int i = 0; i < n; i++)
        {
            // هر جمله از بسط تیلور: (-1)^i * x^(2i) / (2i)!
            double term = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / Factorial(2 * i);
            cosX += term;
        }

        Console.WriteLine($"\nمقدار تقریبی cos({degree}) = {cosX}");
        Console.WriteLine($"مقدار واقعی با Math.Cos = {Math.Cos(x)}");
    }

    // تابع محاسبه فاکتوریل
    static double Factorial(int n)
    {
        double result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }
}