using MarsRover.RoverLocation;
using MarsRover.RoverMotion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
    [TestClass]
    public class PlateauTests
    {
        [TestMethod()]
        public void Test_Move_Rover_To_Left_WithSuccessfully()
        {
            int plateuLimitX = 5;
            int plateuLimitY = 5;
            var plateau = new Plateau(plateuLimitX, plateuLimitY);

            var location = new RoverLocation.Location(1, 2);
            string direction = "N";
            var marsRover = new MarsRover.Rover.MarsRover(location, direction);
            marsRover.LandRover(plateau);

            plateau.MoveRover("L", marsRover);
            Assert.AreEqual(typeof(WestRoverMotionState), marsRover.state.GetType());
        }

        [TestMethod()]
        public void Test_Move_Rover_To_Right_WithSuccessfully()
        {
            int plateuLimitX = 5;
            int plateuLimitY = 5;
            var plateau = new Plateau(plateuLimitX, plateuLimitY);

            var location = new RoverLocation.Location(1, 2);
            string direction = "W";
            var marsRover = new MarsRover.Rover.MarsRover(location, direction);
            marsRover.LandRover(plateau);

            plateau.MoveRover("R", marsRover);
            Assert.AreEqual(typeof(NorthRoverMotionState), marsRover.state.GetType());
        }       
    }
}
