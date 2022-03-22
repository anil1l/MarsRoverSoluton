using MarsRover.RoverLocation;

namespace MarsRover.RoverMotion.Base
{
    public abstract class BaseRoverMotionState
    {
        public Location Location { get; set; }
        public Plateau Plateau { get; set; }
        public BaseRoverMotionState(Location location, Plateau plateau)
        {
            this.Location = location;
            this.Plateau = plateau;
        }
        public abstract BaseRoverMotionState TurnLeft();
        public abstract BaseRoverMotionState TurnRight();
        public abstract void Move();
    }
}
