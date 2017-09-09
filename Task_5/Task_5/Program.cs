using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Программа считает сумму элементов вернхнего треугольника квадратной матрицы
Например: матрица 5х5:");
            for(int i =0; i<5; i++)
            {
                for (int j=0; j<5; j++)
                {
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if ((j > 0) && (j < 4)&&(i==1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (j==2 && (i == 2))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write("X ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите размер квадратной матрицы");
            Console.WriteLine("Для вычисления ");

            Random rnd = new Random();
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 2 && N % 2 == 1)
            {

                double[] MasDouble = new double[N];



            }


        }
    }
}
