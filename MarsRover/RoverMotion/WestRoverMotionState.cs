using MarsRover.RoverMotion.Base;
using MarsRover.RoverLocation;

namespace MarsRover.RoverMotion
{
    public class WestRoverMotionState : BaseRoverMotionState
    {
        public WestRoverMotionState(Location location, Plateau plateau) : base(location, plateau)
        {

        }
        public override void Move()
        {
            if (Plateau.CheckTheRoverIsInThePlateau(base.Location))
            {
                base.Location.X--;
            }
        }

        public override BaseRoverMotionState TurnLeft()
        {
            return new SouthRoverMotionState(Location, Plateau);
        }

        public override BaseRoverMotionState TurnRight()
        {
            return new NorthRoverMotionState(Location, Plateau);
        }
    }
}
