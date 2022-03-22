using MarsRover.RoverLocation;
using MarsRover.RoverMotion.Base;

namespace MarsRover.RoverMotion
{
    public class NorthRoverMotionState : BaseRoverMotionState
    {
        public NorthRoverMotionState(Location location, Plateau plateau) : base(location, plateau)
        {

        }
        public override void Move()
        {
            if (Plateau.CheckTheRoverIsInThePlateau(base.Location))
            {
                base.Location.Y++;
            }
        }

        public override BaseRoverMotionState TurnLeft()
        {
            return new WestRoverMotionState(Location, Plateau);
        }

        public override BaseRoverMotionState TurnRight()
        {
            return new EastRoverMotionState(Location, Plateau);
        }
    }
}
