using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {   //задание 3.1
            //Имеется 3 числа: a, b, c. Составить логические выражения, с помощью которых можно проверить истинность утверждений:
            //•	среди них есть хотя бы одно отрицательное;
            //•	среди них есть хотя бы одно четное;
            //•	хотя бы одно из их произведений – ab, bc, ac – превосходит их сумму a+b + c.

            Console.WriteLine("введите три числа: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.Write("Есть ли среди чисел отрицательное :");
            bool v = a < 0 || b < 0 || c < 0;
            Console.WriteLine(v);

            Console.Write("Есть ли среди чисел одно чётное : ");
            bool g = a % 2 == 0 || b % 2 == 0 || c % 2 == 0; 
            Console.WriteLine(g);

            Console.Write("одно из их произведений – ab, bc, ac – превосходит их сумму a+b + c : ");
            bool t = a * b > a + b + c || b * c > a + b + c || a * c > a + b + c;
            Console.Write(t);




        }
    }
}
