using MarsRover.Helper;
using MarsRover.Rover;
using MarsRover.RoverLocation;
using System;
using System.Collections.Generic;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Plateau
            string plateauLimitInput = Console.ReadLine();
            string[] plateauLimits = UserInputHelper.GetPlateauLimits(plateauLimitInput);
            var plateau = new Plateau(Convert.ToInt32(plateauLimits[0]), Convert.ToInt32(plateauLimits[0]));

            //Define Rover Location and Direction
            string roverLocationAndDirectionInput = Console.ReadLine();
            string[] roverLocationAndDirection = UserInputHelper.GetRoverLocationInfo(roverLocationAndDirectionInput);
            var roverLocation = new Location(Convert.ToInt32(roverLocationAndDirection[0]), Convert.ToInt32(roverLocationAndDirection[1]));
            string direction = roverLocationAndDirection[2];

            var roverIsInThePlateau = plateau.CheckTheRoverIsInThePlateau(roverLocation);

            if (!roverIsInThePlateau)
            {
                throw new ArgumentException("The Rover is not in the plateau limits!!!");
            }

            //Land Rover To The Plateau
            IRover marsRover = new MarsRover.Rover.MarsRover(roverLocation, direction);
            marsRover.LandRover(plateau);

            string motionsInput = Console.ReadLine();
            List<char> motions = UserInputHelper.GetMotions(motionsInput);

            foreach (var motion in motions)
            {
                plateau.MoveRover(motion.ToString(), marsRover);
            }
            Console.WriteLine(marsRover.ToString());
            Console.ReadKey();
        }




    }
}
