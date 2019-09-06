using SnakeCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class ConsoleTable : IGameTable
    {
        string[,] matrix;
        int max_x;
        int max_y;
        public ConsoleTable(int x, int y)
        {
            max_x = x;
            max_y = y;
             matrix = new string[x,y];
            DrawFrame(x,y);
        }

        private void DrawFrame(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                matrix[i, 0] = "X";
                matrix[i, y-1] = "X";
            }
            //for (int i = 0; i < y; i++)
            //{
            //    matrix[0, i] = "X";
            //    matrix[x-1, i] = "X";
            //}
        }

        public void Draw()
        {
            var sb = new StringBuilder(matrix.Length + max_x, matrix.Length + max_x);
            for (int i = 0; i < max_x; i++)
            {
                for (int j = 0; j < max_y; j++)
                {
                    sb.Append(matrix[i, j]);
                }
                sb.Append("\n");
            }
            Console.WriteLine(sb);
        }

        public void SetFood(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }

        public void SetSnakePosition(Snake snake)
        {
            throw new NotImplementedException();
        }
    }
}
