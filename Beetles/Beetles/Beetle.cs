using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Beetles
{
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
        public Beetle(int energy, Genotype genotype, Coord coord)
        {
            isDie = false;
            Energy = energy;
            Genotype = genotype;
            Coord = coord;
        }
        public void Run()
        {
            while (!isDie)
            {
                Random random = new Random();
                if (Energy != 0)
                {
                    int div = random.Next(100);
                    if (Energy > 70 && div == 1)
                    {
                        // Divide();
                    }
                    Coord curCoord = Coord;
                    Program.curForm.ChangedColorOfPixel(curCoord, Color.Black);
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
                    Program.curForm.ChangedColorOfPixel(Coord, Color.White);
                    Thread.Sleep(1000);
                }
                else
                {
                    isDie = true;
                }
            }

        }
        void Divide()
        {
            Beetle newBeetle = new Beetle(Energy / 2, Genotype.Mutation(), Coord);
            Thread BeetleThread = new Thread(new ThreadStart(newBeetle.Run));
            BeetleThread.Start();
        }
    }


}
