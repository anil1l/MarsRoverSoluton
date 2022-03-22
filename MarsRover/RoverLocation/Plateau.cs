using MarsRover.Rover;
using MarsRover.RoverLocation.Enum;

namespace MarsRover.RoverLocation
{
    public class Plateau
    {
        public readonly int X;
        public readonly int Y;

        public Plateau(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool CheckTheRoverIsInThePlateau(Location roverLocation)
        {
            if (roverLocation.X <= this.X && roverLocation.Y <= this.Y && roverLocation.X >= 0 && roverLocation.Y >= 0)
                return true;
            return false;
        }

        public void MoveRover(string motion, IRover marsRover)
        {
            switch (motion)
            {
                case nameof(Motions.M):
                    marsRover.Move();
                    break;
                case nameof(Motions.L):
                    marsRover.TurnLeft();
                    break;
                case nameof(Motions.R):
                    marsRover.TurnRight();
                    break;
                default:
                    break;
            }
        }
    }
}
