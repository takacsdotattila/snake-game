using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeCore;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = InitializeCliTable();
            table.Draw();
            //var game = new Game();
        }

        private static IGameTable InitializeCliTable()
        {
            return new ConsoleTable(10,10);

        }
    }
}
