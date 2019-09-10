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
            FillFrame();
            FillSpaces(); 
        }

        private void FillFrame()
        {
            for (int i = 0; i < max_x; i++)
            {
                matrix[i, 0] = "X";
                matrix[i, max_y-1] = "X";
            }
            for (int i = 0; i < max_y; i++)
            {
                matrix[0, i] = "X";
                matrix[max_x - 1, i] = "X";
            }
        }

        private void FillSpaces() {
            for (int i = 1; i < max_x-1; i++)
            {
                for (int j = 1; j < max_y-1; j++)
                {
                    matrix[i, j] = " ";
                }
            }
        }

        public void Draw()
        {
            var sb = new StringBuilder(matrix.Length *2 + max_x);
            for (int i = 0; i < max_x; i++)
            {
                for (int j = 0; j < max_y; j++)
                {
                    sb.Append(matrix[i, j]+' ');
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
