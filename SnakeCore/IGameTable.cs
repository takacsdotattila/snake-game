using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCore
{
    // This is an 0 based matrix concept
    public interface IGameTable
    {
        void Draw();
        void SetFood(Coordinate coordinate);
        void SetSnakePosition(Snake snake);
    }
}
