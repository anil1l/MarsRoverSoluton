using MarsRover.RoverLocation;

namespace MarsRover.Rover
{
    public interface IRover
    {
        void LandRover(Plateau plateau);
        void Move();
        void TurnLeft();
        void TurnRight();
    }
}
