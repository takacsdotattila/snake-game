using System;
using Moq;
using SnakeCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameCoreUnitTest
{
    [TestClass]
    public class MovingTest
    
    {
        [TestMethod]
        public void ChangeDirectionColckwise()
        {
            var  mymock = new Mock<IGameTable>();
            var myTable = mymock.Object;

            var game = new Game(myTable);

            //set_to up
            Assert.AreEqual(Direction.None, game.CurrentDirection);
            Assert.AreEqual(true, game.TryChangeDirection(Direction.Up));
            Assert.AreEqual(Direction.Up, game.CurrentDirection);

            //stay
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Up));
            Assert.AreEqual(Direction.Up, game.CurrentDirection);
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Down));            
            Assert.AreEqual(Direction.Up, game.CurrentDirection);
            //right
            Assert.AreEqual(true, game.TryChangeDirection(Direction.Right));
            Assert.AreEqual(Direction.Right, game.CurrentDirection);
            //stay
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Left));
            Assert.AreEqual(Direction.Right, game.CurrentDirection);
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Right));
            Assert.AreEqual(Direction.Right, game.CurrentDirection);
            // down
            Assert.AreEqual(true, game.TryChangeDirection(Direction.Down));
            Assert.AreEqual(Direction.Down, game.CurrentDirection);
            //stay
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Up));
            Assert.AreEqual(Direction.Down, game.CurrentDirection);
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Down));
            Assert.AreEqual(Direction.Down, game.CurrentDirection);
            //flip None
            Assert.AreEqual(true, game.TryChangeDirection(Direction.None));
            Assert.AreEqual(Direction.None, game.CurrentDirection);
            Assert.AreEqual(true, game.TryChangeDirection(Direction.Down));
            Assert.AreEqual(Direction.Down, game.CurrentDirection);
            //left
            Assert.AreEqual(true, game.TryChangeDirection(Direction.Left));
            Assert.AreEqual(Direction.Left, game.CurrentDirection);
            //stay
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Left));
            Assert.AreEqual(Direction.Left, game.CurrentDirection);
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Right));
            Assert.AreEqual(Direction.Left, game.CurrentDirection);
            //up
            Assert.AreEqual(true, game.TryChangeDirection(Direction.Up));
            Assert.AreEqual(Direction.Up, game.CurrentDirection);
        }

        [TestMethod]
        public void ChangeDirectionAntiColckwise()
        {
            var mymock = new Mock<IGameTable>();
            var myTable = mymock.Object;

            var game = new Game(myTable);

            //set_to up
            Assert.AreEqual(Direction.None, game.CurrentDirection);
            Assert.AreEqual(true, game.TryChangeDirection(Direction.Up));
            Assert.AreEqual(Direction.Up, game.CurrentDirection);

            //stay
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Up));
            Assert.AreEqual(Direction.Up, game.CurrentDirection);
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Down));
            Assert.AreEqual(Direction.Up, game.CurrentDirection);

            //left
            Assert.AreEqual(true, game.TryChangeDirection(Direction.Left));
            Assert.AreEqual(Direction.Left, game.CurrentDirection);
            //stay
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Left));
            Assert.AreEqual(Direction.Left, game.CurrentDirection);
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Right));
            Assert.AreEqual(Direction.Left, game.CurrentDirection);
            // down
            Assert.AreEqual(true, game.TryChangeDirection(Direction.Down));
            Assert.AreEqual(Direction.Down, game.CurrentDirection);
            //stay
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Up));
            Assert.AreEqual(Direction.Down, game.CurrentDirection);
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Down));
            Assert.AreEqual(Direction.Down, game.CurrentDirection);
            //right
            Assert.AreEqual(true, game.TryChangeDirection(Direction.Right));
            Assert.AreEqual(Direction.Right, game.CurrentDirection);
            //stay
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Left));
            Assert.AreEqual(Direction.Right, game.CurrentDirection);
            Assert.AreEqual(false, game.TryChangeDirection(Direction.Right));
            Assert.AreEqual(Direction.Right, game.CurrentDirection);
            //up
            Assert.AreEqual(true, game.TryChangeDirection(Direction.Up));
            Assert.AreEqual(Direction.Up, game.CurrentDirection);

        }

        [TestMethod]
        public void ChangeDirectionFromLeftToUp()
        {
            

        }
    }
}
