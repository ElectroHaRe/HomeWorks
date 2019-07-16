using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MyMatrix
    {
        public MyMatrix(int x,int y)
        {
            x_length = x;
            y_length = y;
            matrix = new int[x, y];
            Random rand = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = rand.Next(0,100);
                }
            }
        }

        private int x_length;
        private int y_length;

        public readonly int[,] matrix;

        /// <summary>
        /// Возвращает массив матриц заданного размера, вырезанных из основной матрицы
        /// </summary>
        /// <param name="длинна саб-матрицы"></param>
        /// <param name="высота саб-матрицы"></param>
        /// <returns></returns>
        public int[,][,] this[int x, int y]
        {
            get
            {
                int _x = x_length - x > 0 ? x_length - x + 1: 1;
                int _y = y_length - y > 0 ? y_length - y + 1: 1;

                int[,][,] m = new int[_x,_y][,];

                int[,] subMatrix = new int[x, y];

                for (int i = 0; i < _x; i++)
                {
                    for (int j = 0; j < _y; j++)
                    {
                        for (int k = 0; k < x; k++)
                        {
                            for (int s = 0; s < y; s++)
                            {
                                if (k < x_length && s < y_length)
                                    subMatrix[k, s] = matrix[k+i, s+j];
                                else subMatrix[k, s] = 1;
                            }
                        }
                        m[i, j] = subMatrix;
                        subMatrix = new int[x, y];
                    }
                }
                return m;
            }
        }
    }
}
