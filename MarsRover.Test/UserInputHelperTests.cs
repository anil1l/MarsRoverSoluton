using MarsRover.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MarsRover.Test
{
    [TestClass]
    public class UserInputHelperTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "You should enter a valid location information!!!")]
        public void Test_Set_roverLocationAndDirectionInput_With_Over_Information()
        {
            string roverLocationAndDirectionInput = "1 2 N N";
            UserInputHelper.GetRoverLocationInfo(roverLocationAndDirectionInput);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "You should enter a valid location information!!!")]
        public void Test_Set_roverLocationAndDirectionInput_With_Less_Information()
        {
            string roverLocationAndDirectionInput = "1 2";
            UserInputHelper.GetRoverLocationInfo(roverLocationAndDirectionInput);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "You should enter a valid location information!!!Check the location info which is X : N")]
        public void Test_Set_roverLocationAndDirectionInput_With_Wrong_X_Information()
        {
            string roverLocationAndDirectionInput = "N 1 N";
            UserInputHelper.GetRoverLocationInfo(roverLocationAndDirectionInput);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "You should enter a valid location information!!!Check the location info which is Y : S")]
        public void Test_Set_roverLocationAndDirectionInput_With_Wrong_Y_Information()
        {
            string roverLocationAndDirectionInput = "1 S N";
            UserInputHelper.GetRoverLocationInfo(roverLocationAndDirectionInput);
        }

        [TestMethod()]
        public void Test_Set_roverLocationAndDirectionInput_With_Succesfully()
        {
            string roverLocationAndDirectionInput = "1 2 N";
            string[] expected = new string[] { "1", "2", "N" };
            string[] actual = UserInputHelper.GetRoverLocationInfo(roverLocationAndDirectionInput);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);

        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "You should enter valid plateau limits!!!")]
        public void Test_Set_PlateauLimitsInput_With_Over_Information()
        {
            string plateauLimitsInput = "5 5 5";
            UserInputHelper.GetPlateauLimits(plateauLimitsInput);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "You should enter valid plateau limits!!!")]
        public void Test_Set_PlateauLimitsInput_With_Less_Information()
        {
            string plateauLimitsInput = "5";
            UserInputHelper.GetPlateauLimits(plateauLimitsInput);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "You should enter a valid location information!!!Checkplateau limits X: N")]
        public void Test_Set_PlateauLimitsInput_With_Wrong_X_Information()
        {
            string plateauLimitsInput = "N 5";
            UserInputHelper.GetPlateauLimits(plateauLimitsInput);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "You should enter a valid location information!!!Checkplateau limits Y: N")]
        public void Test_Set_PlateauLimitsInput_With_Wrong_Y_Information()
        {
            string plateauLimitsInput = "5 N";
            UserInputHelper.GetPlateauLimits(plateauLimitsInput);
        }

        [TestMethod()]
        public void Test_Set_PlateauLimitsInput_With_Succesfully()
        {
            string plateauLimitsInput = "5 5";
            string[] expected = new string[] { "5", "5" };
            string[] actual = UserInputHelper.GetPlateauLimits(plateauLimitsInput);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);

        }
    }
}
