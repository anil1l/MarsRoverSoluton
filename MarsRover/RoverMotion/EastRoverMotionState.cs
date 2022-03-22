using MarsRover.RoverLocation;
using MarsRover.RoverMotion.Base;

namespace MarsRover.RoverMotion
{
    public class EastRoverMotionState : BaseRoverMotionState
    {
        public EastRoverMotionState(Location location, Plateau plateau) : base(location, plateau)
        {

        }
        public override void Move()
        {
            if (Plateau.CheckTheRoverIsInThePlateau(base.Location))
            {
                base.Location.X++;
            }
        }

        public override BaseRoverMotionState TurnLeft()
        {
            return new NorthRoverMotionState(Location, Plateau);
        }

        public override BaseRoverMotionState TurnRight()
        {
            return new SouthRoverMotionState(Location, Plateau);
        }
    }
}
