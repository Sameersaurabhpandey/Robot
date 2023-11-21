using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot
{
    public class ToyRobot1
    {
        private const int TableSize = 5;

        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Facing { get; private set; }

        public void Place(int x, int y, Direction facing)
        {
            if (IsValidPosition(x, y))
            {
                X = x;
                Y = y;
                Facing = facing;
            }
        }

        public void Move()
        {
            int newX = X;
            int newY = Y;

            switch (Facing)
            {
                case Direction.NORTH:
                    newY++;
                    break;
                case Direction.EAST:
                    newX++;
                    break;
                case Direction.SOUTH:
                    newY--;
                    break;
                case Direction.WEST:
                    newX--;
                    break;
            }

            if (IsValidPosition(newX, newY))
            {
                X = newX;
                Y = newY;
            }
        }

        public void TurnLeft()
        {
            Facing = (Direction)(((int)Facing + 3) % 4);
        }

        public void TurnRight()
        {
            Facing = (Direction)(((int)Facing + 1) % 4);
        }

        public string Report()
        {
            return $"{X},{Y},{Facing}";
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < TableSize && y >= 0 && y < TableSize;
        }

    }
}
