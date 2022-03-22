using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Helper
{
    public static class UserInputHelper
    {
        public static List<char> GetMotions(string motionsInput)
        {
            var motions = motionsInput.ToList();
            return motions;
        }

        public static string[] GetPlateauLimits(string plateauLimitInput)
        {
            string[] plateauLimits = plateauLimitInput.Split(" ");
            if (plateauLimits.Length != 2)
            {
                throw new ArgumentException("You should enter valid plateau limits!!!");
            }
            if (!Int32.TryParse(plateauLimits[0], out int x))
            {
                throw new ArgumentException($"You should enter a valid location information!!!Checkplateau limits X: {x}");
            }

            if (!Int32.TryParse(plateauLimits[1], out int y))
            {
                throw new ArgumentException($"You should enter a valid location information!!!Checkplateau limits Y: {y}");
            }
            return plateauLimits;
        }

        public static string[] GetRoverLocationInfo(string roverLocationAndDirectionInput)
        {
            string[] roverLocationAndDirection = roverLocationAndDirectionInput.Split(" ");

            if (roverLocationAndDirection.Length != 3)
            {
                throw new ArgumentException("You should enter a valid location information!!!");
            }

            if (!Int32.TryParse(roverLocationAndDirection[0], out int x))
            {
                throw new ArgumentException($"You should enter a valid location information!!!Check the location info which is X :{x}");
            }
            if (!Int32.TryParse(roverLocationAndDirection[1], out int y))
            {
                throw new ArgumentException($"You should enter a valid location information!!!Check the location info which is Y :{y}");
            }
            return roverLocationAndDirection;
        }
    }
}
