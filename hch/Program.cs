Console.WriteLine("1. Сложение двух чисел ");
Console.WriteLine("2. Вычесть одного числа из другого");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое число на второе");
Console.WriteLine("5. Вовзести в N степень первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал числа");
Console.WriteLine("9. Выход из программы");
int r = Convert.ToInt32(Console.ReadLine());
int a, b, c;
int zadaca = 0;
do
{

    switch (r)

    {
        case 1:
            Console.Write("Первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Sum = {0}", c);
            Console.ReadLine();
            break;
        case 2:
            Console.Write("Первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число");
            b = Convert.ToInt32(Console.ReadLine());
            c = a - b;
            Console.WriteLine( c);
            Console.ReadLine();
            break;
        case 3:
            Console.Write("Первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число");
            b = Convert.ToInt32(Console.ReadLine());
            c = a * b;
            Console.WriteLine(c);
            Console.ReadLine();
            break;
        case 4:
            Console.Write("Первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число");
            b = Convert.ToInt32(Console.ReadLine());
            c = a / b;
            Console.WriteLine(c);
            Console.ReadLine();
            break;
        case 5:
            Console.WriteLine("Введите число");
            double A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
            double D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((Math.Pow(A, D)));
            Console.ReadLine();
            break;

        case 6:
            Console.WriteLine("Введите число");
            double B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((Math.Sqrt(B)));
            Console.ReadLine();

            break;
        case 7:
            Console.WriteLine("Введите число");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((C / 100));
            break;
        case 8:
            int F = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int x = 1; x <= F; x++) ;
            break;
    }
    r = Convert.ToInt32(Console.ReadLine());
}
while (zadaca != 9);