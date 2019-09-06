using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCore
{
    public class Snake
    {
        public Direction Direction { get; set; }
        public int Size { get; private set; }

        public void Eat() {
            Size++;

        }
    }
}
