using System;

namespace Matrix
{
    class Program
    {

        static void Main(string[] args)
        {
            start:

            int x = 0;
            int y = 0;

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Задайте размер матрицы");

            #region Задание размера основной матрицы

            Console.SetCursorPosition(0, Console.CursorTop + 2);

            Console.Write("количество строк : ");

            try
            {
                x = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                Console.WriteLine("Ввод не распознан");
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.Write("_", 30);
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                goto start;
            }

            Console.Write("количество столбцов : ");

            try
            {
                y = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                Console.WriteLine("Ввод не распознан");
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.Write("_", 30);
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                goto start;
            }

            if (x == 0 || y == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                Console.Write("Матрица не может иметь 0 строк или столбцов!");
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.Write("_", 30);
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                goto start;
            }

            #endregion

            MyMatrix matrix = new MyMatrix(x, y);

            int _x = 0;
            int _y = 0;

            #region Задание размера sub матрицы

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.WriteLine("Задайте размер подматриц");

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.Write("количество строк : ");

            try
            {
                _x = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                Console.WriteLine("Ввод не распознан");
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.Write("_", 30);
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                goto start;
            }

            Console.Write("количество столбцов : ");

            try
            {
                _y = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                Console.WriteLine("Ввод не распознан");
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.Write("_", 30);
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                goto start;
            }

            if (_x == 0 || _y == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                Console.Write("Матрица не может иметь 0 строк или столбцов!");
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.Write("_", 30);
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                goto start;
            }

            #endregion

            Console.WriteLine("Главная матрица :");

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(matrix.matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(0, Console.CursorTop + 2);

            Console.WriteLine("Sub матрицы : ");

            int[,][,] m = matrix[_x, _y];

            int x_m = 1;

            for (int i = 0; i <= m.Length; i++)
            {
                try
                {
                    int[,] temp = m[i, 0];
                }
                catch {
                    x_m = i;
                    break;
                }
            }


            for (int i = 0; i < x_m; i++)
            {
                for (int j = 0; j < m.Length / x_m; j++)
                {
                    Console.SetCursorPosition(0, Console.CursorTop + 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Матрица ( {0} , {1} ):", i, j);
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    Console.ForegroundColor = ConsoleColor.Gray;

                    for (int k = 0; k < _x; k++)
                    {
                        for (int s = 0; s < _y; s++)
                        {
                            Console.Write(m[i, j][k, s] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.SetCursorPosition(0, Console.CursorTop + 2);

            Console.WriteLine("1 - Repeat | 2 - Exit");

            switch (Console.ReadLine()) {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(0, Console.CursorTop + 2);
                    Console.Write("_",30);
                    Console.SetCursorPosition(0, Console.CursorTop + 2);
                    goto start;
                default:
                    break;
            }
        }
    }
}
