using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTester
{
    public class Enums
    {
        public enum Direction
        {
            Err = -1,
            Long = 0,
            Short = 1,
        }

        public static Direction StringToDirection(string strDir)
        {
            Direction direction = Direction.Err;
            switch(strDir)
            {
                default:
                case "Err":
                    direction = Direction.Err;
                    break;
                case "Long":
                    direction = Direction.Long;
                    break;
                case "Short":
                    direction = Direction.Short;
                    break;
            }
            return direction;
        }

        public static string DirectionToString(Direction direction)
        {
            string directionStr;
            switch (direction)
            {
                default:
                case Direction.Err:
                    directionStr = "Err";
                    break;
                case Direction.Long:
                    directionStr = "Long";
                    break;
                case Direction.Short:
                    directionStr = "Short";
                    break;
            }
            return directionStr;
        }
    }
}
