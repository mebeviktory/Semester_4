using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Beetles
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Form1 form;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            Application.Run(form);
        }
    }
    class Beetle
    {
        public bool isDie;
        public int Energy;
        public Genotype Genotype;
        public Coord Coord;

        public Coord GetCoord
        {
            get
            {
                return this.Coord;
            }
            set
            {
                this.Coord = value;
            }
        }

        Random random = new Random();
        public Beetle(int energy, Genotype genotype, Coord coord)
        {
            isDie = false;
            Energy = energy;
            Genotype = genotype;
            Coord = coord;
        }
        public void Run()
        {
            if (Energy != 0)
            {
                Coord curCoord = Coord;
                int number = random.Next(100);
                int dist = Genotype.Check(number);
                switch (dist)
                {
                    case 1:
                        Coord.MovedUp();
                        break;
                    case 2:
                        Coord.MovedRight();
                        break;
                    case 3:
                        Coord.MovedDown();
                        break;
                    case 4:
                        Coord.MovedLeft();
                        break;
                }
                Energy--;
            }
            else
            {
                isDie = true;
            }
            //Program.form.ChangedColorOfPixel(curCoord,Color.Black);
            //Program.form.ChangedColorOfPixel(Coord, Color.White);
        }
        void Divide()
        {
            //Beetle newBeetle = new Beetle();
        }
    }

    class Genotype
    {
        Random rnd = new Random();
        public int upPoint;
        public int rightPoint;
        public int downPoint;
        public Genotype(int up, int right, int down)
        {
            upPoint = up;
            rightPoint = right;
            downPoint = down;

        }
        public void Mutation()
        {
            int num = rnd.Next(3);
            int delta = rnd.Next(-5,5);
            switch (num)
            {
                case 0:
                    upPoint += delta;
                    if(upPoint<0)
                    {
                        upPoint = 1;
                    }
                    else if(upPoint>rightPoint)
                    {
                        int number = upPoint;
                        upPoint = rightPoint;
                        rightPoint = number;
                    }
                    break;
                case 1:
                    rightPoint += delta;
                    if (rightPoint < upPoint)
                    {
                        int number = upPoint;
                        upPoint = rightPoint;
                        rightPoint = number;
                    }
                    else if(rightPoint>downPoint)
                    {
                        int number = downPoint;
                        downPoint = rightPoint;
                        rightPoint = number;
                    }
                    break;
                case 2:
                    downPoint += delta;
                    if (downPoint > 100)
                    {
                        downPoint = 99;
                    }
                    else if (downPoint < rightPoint)
                    {
                        int number = downPoint;
                        downPoint = rightPoint;
                        rightPoint = number;
                    }
                    break;
            }

        }
        public int Check(int number)
        {
            if (number <= upPoint)
            {
                return 1;
            }
            else if (number <= rightPoint)
            {
                return 2;
            }
            else if (number <= downPoint)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }

    public class Coord
    {
        int height = 308;
        int width = 450;
        public void MovedUp()
        {
            if(this.Y==0)
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
