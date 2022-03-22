using MarsRover.RoverLocation;
using MarsRover.RoverMotion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
    [TestClass]
    public class RoverTests
    {

        [TestMethod()]
        public void Test_Land_Rover_WithSuccessfully()
        {
            var marsRover = GenerateObject();
            string expectedDirection = "N";
            int expectedXLocation = 1;
            int expectedYLocation = 2;

            Assert.AreEqual(expectedDirection, marsRover.direction);
            Assert.AreEqual(expectedXLocation, marsRover.location.X);
            Assert.AreEqual(expectedYLocation, marsRover.location.Y);
            Assert.AreEqual(typeof(NorthRoverMotionState), marsRover.state.GetType());
        }

        [TestMethod()]
        public void Test_Turn_Rover_To_Left_WithSuccessfully()
        {
            var marsRover = GenerateObject();
            marsRover.TurnLeft();
            Assert.AreEqual(typeof(WestRoverMotionState), marsRover.state.GetType());
        }

        [TestMethod()]
        public void Test_Turn_Rover_To_Right_WithSuccessfully()
        {
            var marsRover = GenerateObject();
            marsRover.TurnRight();
            Assert.AreEqual(typeof(EastRoverMotionState), marsRover.state.GetType());
        }

        [TestMethod()]
        public void Test_Move_Rover_Forward_WithSuccessfully()
        {
            var marsRover = GenerateObject();
            marsRover.Move();
            int expectedXLocation = 1;
            int expectedYLocation = 3;
            Assert.AreEqual(typeof(NorthRoverMotionState), marsRover.state.GetType());
            Assert.AreEqual(expectedYLocation, marsRover.location.Y);
            Assert.AreEqual(expectedXLocation, marsRover.location.X);

        }
        private MarsRover.Rover.MarsRover GenerateObject()
        {
            int plateuLimitX = 5;
            int plateuLimitY = 5;
            var plateau = new Plateau(plateuLimitX, plateuLimitY);
            var location = new RoverLocation.Location(1, 2);
            string direction = "N";
            var marsRover = new MarsRover.Rover.MarsRover(location, direction);
            marsRover.LandRover(plateau);
            return marsRover;
        }
    }
}
