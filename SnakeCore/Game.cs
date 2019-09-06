using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeCore
{
    public class Game
    {
        public Direction CurrentDirection { get; private set; }
        private IGameTable table;
        private Timer timer;
        private bool IsGameStarted = false;
        private int interval;
        private Coordinate FoodPosition;


        public Game(IGameTable table, int interval = 1000)
        {
            this.interval = interval;
            this.table = table;
            CurrentDirection = Direction.None;
        }

        public void StartGame()
        {
            if (IsGameStarted) return;
            IsGameStarted = true;
            timer = new Timer(TimerTick, this, 0, interval);
        }

        private Coordinate CalculateFoodPosition() {
            return new Coordinate() {X=2,Y=2 };
        }

        public void UpdateTable()
        {
            table.Draw();
        }
        private void TimerTick(object o)
        {
            UpdateTable();
        }

        public bool TryChangeDirection(Direction direction)
        {
            if (IsValidMove(direction))
            {
                CurrentDirection = direction;
                return true;
            }
            return false;
        }

        private bool IsValidMove(Direction direction)
        {
            switch (CurrentDirection)
            {
                case Direction.None:
                    return direction != Direction.None;

                case Direction.Up:
                case Direction.Down:
                    return (Direction.Right | Direction.Left).HasFlag(direction);

                case Direction.Left:
                case Direction.Right:
                    return (Direction.Up | Direction.Down).HasFlag(direction);

                default:
                    return false;
            }
        }



    }


}
