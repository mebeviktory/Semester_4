using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beetles
{
    public class Coord
    {
        int height = 437;
        int width = 549;
        public void MovedUp()
        {
            if (this.Y == 0)
            {
                this.Y = height;
            }
            else
            {
                this.Y--;
            }
        }
        public void MovedRight()
        {
            if (this.X == width)
            {
                this.X = 0;
            }
            else
            {
                this.X++;
            }
        }
        public void MovedDown()
        {
            if (this.Y == height)
            {
                this.Y = 0;
            }
            else
            {
                this.Y++;
            }
        }
        public void MovedLeft()
        {
            if (this.X == 0)
            {
                this.X = width;
            }
            else
            {
                this.X--;
            }
        }
        private int x;
        private int y;
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        public Coord(int xCoord, int yCoord)
        {
            x = xCoord;
            y = yCoord;

        }

    }
}
