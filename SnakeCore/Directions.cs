using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCore
{
    [Flags]
    public enum Direction
    {
        None = 0,
        Up = 1,
        Left = 2,
        Down = 4,
        Right = 8
    }

}
