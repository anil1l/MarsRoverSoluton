using MarsRover.RoverMotion;
using MarsRover.RoverMotion.Base;
using MarsRover.RoverLocation;
using MarsRover.RoverLocation.Enum;
using System;

namespace MarsRover.Rover
{
    public class MarsRover : IRover
    {
        public Location location;
        public string direction;
        public BaseRoverMotionState state;
        public MarsRover(Location location, string direction)
        {
            this.direction = direction;
            this.location = location;
        }


        public void LandRover(Plateau plateau)
        {
            switch (direction)
            {
                case nameof(Directions.N):
                    state = new NorthRoverMotionState(location, plateau);
                    break;
                case nameof(Directions.E):
                    state = new EastRoverMotionState(location, plateau);
                    break;
                case nameof(Directions.W):
                    state = new WestRoverMotionState(location, plateau);
                    break;
                case nameof(Directions.S):
                    state = new SouthRoverMotionState(location, plateau);
                    break;
                default:
                    throw new ArgumentException("The Rover is not in the plateau limits!!!");
            }
        }

        public void Move()
        {
            state.Move();
        }

        public void TurnLeft()
        {
            state = state.TurnLeft();
        }

        public void TurnRight()
        {
            state = state.TurnRight();
        }

        public override string ToString()
        {
            return this.location.X + " " + this.location.Y + " " + this.direction;
        }
    }
}
