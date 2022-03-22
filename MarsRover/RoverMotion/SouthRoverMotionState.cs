using MarsRover.RoverMotion.Base;
using MarsRover.RoverLocation;

namespace MarsRover.RoverMotion
{
    public class SouthRoverMotionState : BaseRoverMotionState
    {
        public SouthRoverMotionState(Location location, Plateau plateau) : base(location, plateau)
        {

        }
        public override void Move()
        {
            if (Plateau.CheckTheRoverIsInThePlateau(base.Location))
            {
                base.Location.Y--;
            }
        }

        public override BaseRoverMotionState TurnLeft()
        {
            return new EastRoverMotionState(Location, Plateau);
        }

        public override BaseRoverMotionState TurnRight()
        {
            return new WestRoverMotionState(Location, Plateau);
        }
    }
}
