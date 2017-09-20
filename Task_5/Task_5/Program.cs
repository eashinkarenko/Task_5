using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Программа считает сумму элементов вернхнего треугольника квадратной матрицы
Например: матрица 5х5:");
            //печать примера
            //  х х х 
            //  х х х 
            //  х х х 
            // печать рпимера 
            for (int i =0; i<5; i++)
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

            
            Console.Write("Введите размер квадратной матрицы : ");
            
            Random rnd = new Random();
            int N = 0;
            //задаётся размерность матрицы
            bool ok = false;
            while (ok == false)
            {
                try
                {
                    N = Convert.ToInt32(Console.ReadLine());
                    ok = true;

                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный ввод...");
                }
            }
            Console.WriteLine("         Матрица " + N + "x" + N);    
            
            // заполнение матрицы с помощбю ДСЧ      
            if (N > 2 && N % 2 == 1)
            {


                double[,] MasDouble = new double[N,N];
                //заполнение и печать
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        MasDouble[i, j] = rnd.Next(-1000, 1000) + rnd.Next(-100, 100) * 0.01;
                        Console.Write("  " + MasDouble[i, j] + "  ");
                    }
                    Console.WriteLine();
                }

                // подсчёт суммы нужных элементов
                Console.WriteLine("Просуммированные элементы : ");

                // границы для отслеживания нужного участка матрицы и количество просуммированных элементов
                int Start = 0, End = N, CountSumOf = 0;

                // сумма элементов, принадлежащих области
                double CountSum = 0;

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if ((j >= Start) && (j < End) && (i <=End))
                        {
                            CountSumOf++;
                            CountSum += MasDouble[i, j];
                            // параллельная печать суммируемых объектов
                            Console.Write("  " + MasDouble[i, j] + "  ");
                        }
                    }
                    // изменение границ треугольника
                    Start++;
                    End--;
                    if  (i <= End)  Console.WriteLine();
                }
                Console.WriteLine();

                // печать результатов
                Console.WriteLine("Итог суммирования = " + CountSum + " ( " + CountSumOf + " объектов)");
            }
            else Console.Write(@"Извините, работа с данным размером матрицы не может быть выполнена,
так как нельзя выделить четкую область для суммирования в ней элементов.");            
            Console.ReadLine();
        }
    }
}
