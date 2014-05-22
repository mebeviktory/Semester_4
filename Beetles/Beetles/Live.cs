using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Beetles
{
    class Live
    {
        Random rnd = new Random();
        int startPopulation = 20;
        int pictureBoxWidth = 549;
        int pictureBoxHeight = 437;
        //Bitmap front;
        //List<Beetle> beetles;
        //bool[,] food;
        public void StartLive(Form1 form)
        {
            
            //beetles = new List<Beetle>();
            //food = new bool[pictureBoxWidth, pictureBoxHeight];
            for (int i = 0; i < startPopulation; i++)
            {
                int delta = (int)(i / 5);
                int energy = 100;
                int[] gen = new int[3];
                gen[0] = rnd.Next(98);
                gen[1] = rnd.Next(gen[0], 99);
                gen[2] = rnd.Next(gen[1], 100);
                Genotype newGen = new Genotype(gen[0], gen[1], gen[2]);
                int width = rnd.Next(pictureBoxWidth - 1);
                int height = rnd.Next(pictureBoxHeight-1);
                Coord newCoord = new Coord(width,height);
                Beetle newBeetle = new Beetle(energy, newGen, newCoord);
                Thread BeetleThread = new Thread(new ThreadStart(newBeetle.Run));
                BeetleThread.Start();
                //Program.curForm.ChangedColorOfPixel(newBeetle.Coord, Color.Red);
                //beetles.Add(newBeetle);
                //Thread.Sleep(0);
            }
        }
    }
}
