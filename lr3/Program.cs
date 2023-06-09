using System;

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p, h, Rad;
            int variant; 

            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Круг");
            Console.WriteLine("3. Треугольник");
            Console.WriteLine("4. Квадрат");
            Console.WriteLine("5. Параллелограмм");
            Console.WriteLine("6. Трапеция");
          

            string temp = Console.ReadLine();
            try
            {
                variant = Convert.ToInt32(temp);    // преобразование в число
            }
            catch { variant = 0; }

            try
            {

                switch (variant)
            {
                    case 1:
                        Console.Write("Сторона А = ");
                        temp = Console.ReadLine();
                        a = Convert.ToDouble(temp);
                        Console.Write("Сторона B = ");
                        temp = Console.ReadLine();
                        b = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь прямоугольника = " + a * b);
                        break;

                    case 2:
                        Console.Write("Радиус R = ");
                        temp = Console.ReadLine();
                        Rad = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь круга = " + Math.PI * Math.Pow(Rad, 2));
                        break;

                    case 3:
                        Console.Write("Сторона А = ");
                        temp = Console.ReadLine();
                        a = Convert.ToDouble(temp);
                        Console.Write("Сторона B = ");
                        temp = Console.ReadLine();
                        b = Convert.ToDouble(temp);
                        Console.Write("Сторона С = ");
                        temp = Console.ReadLine();
                        c= Convert.ToDouble(temp);
                        p = (a + b + c) / 2;
                        Console.WriteLine("Площадь треугольника = " + Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
                        break;

                    case 4:
                        Console.Write("Сторона А = ");
                        temp = Console.ReadLine();
                        a = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь квадрат = " + a * a);
                        break;

                    case 5:
                        Console.Write("Сторона А = ");
                        temp = Console.ReadLine();
                        a = Convert.ToDouble(temp);
                        Console.Write("Высота = ");
                        temp = Console.ReadLine();
                        h = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь параллелограмма = " + a * h);
                        break;

                    case 6:
                        Console.Write("Длина первого основания А = ");
                        temp = Console.ReadLine();
                        a = Convert.ToDouble(temp);
                        Console.Write("Длина второго основания B = ");
                        temp = Console.ReadLine();
                        b = Convert.ToDouble(temp);
                        Console.Write("Высота h = ");
                        temp = Console.ReadLine();
                        h = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь трапеции = " + (a + b) * h / 2);
                        break;

                    default: Console.WriteLine("Выбор неверен "); break;
                }
            }
            catch { Console.WriteLine("Ошибка при вводе числа"); }

        }
    }
}
