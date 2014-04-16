using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beetles
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int startPopulation = 2000;
        Bitmap front;
        List<Beetle> beetles;
        bool[,] food;
        public Form1()
        {
            InitializeComponent();
            front = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = front;
            beetles = new List<Beetle>();
            food = new bool[pictureBox1.Width, pictureBox1.Height];
            for (int i = 0; i < startPopulation; i++)
            {
                int delta = (int)(i / 5);
                int energy = rnd.Next(100);
                int[] gen = new int[3];
                gen[0] = rnd.Next(98);
                gen[1] = rnd.Next(gen[0],99);
                gen[2] = rnd.Next(gen[1],100);
                Genotype newGen = new Genotype(gen[0],gen[1], gen[2]);
                int width = rnd.Next(pictureBox1.Width-1);
                int height = rnd.Next(pictureBox1.Height-1);
                Coord newCoord = new Coord(width, height);
                Beetle newBeetle = new Beetle(energy, newGen, newCoord);
                beetles.Add(newBeetle);
                ChangedColorOfPixel(newCoord, Color.White);
            }

            for (int i = 0; i < 100; i++)
            {
                SetFood();
                List<Beetle> diedbeetles = new List<Beetle>();
                List<Beetle> newbeetles = new List<Beetle>();
                foreach (Beetle beetle in beetles)
                {
                    Coord currCoord = beetle.GetCoord;
                    ChangedColorOfPixel(currCoord, Color.Black);
                    beetle.Run();
                    if (beetle.isDie)
                    {
                        diedbeetles.Add(beetle);
                    }
                    ChangedColorOfPixel(beetle.Coord, Color.White);
                    if(food[beetle.Coord.X,beetle.Coord.Y])
                    {
                        beetle.Energy += 10;
                        food[beetle.Coord.X, beetle.Coord.Y] = false;
                    }
                    if(beetle.Energy>70 && rnd.Next(100)>10)
                    {
                        beetle.Energy = (int)beetle.Energy / 2;
                        Genotype newGen = new Genotype(beetle.Genotype.upPoint,beetle.Genotype.rightPoint,beetle.Genotype.downPoint);
                        newGen.Mutation();
                        Beetle newBeetle = new Beetle(beetle.Energy,newGen,beetle.Coord);
                        newbeetles.Add(newBeetle);
                    }
                }
                foreach(Beetle beetle in newbeetles)
                {
                    beetles.Add(beetle);
                }
                foreach(Beetle beetle in diedbeetles)
                {
                    ChangedColorOfPixel(beetle.Coord, Color.Black);
                    beetles.Remove(beetle);
                }
                if (beetles.Count==0)
                {
                    break;
                }
            }

            Console.WriteLine(beetles.Count);
            
        }
        public void SetFood()
        {
            Random rnd = new Random();
            int foodCount = 200;
            for(int i = 0; i < foodCount; i++)
            {
                int x = rnd.Next(pictureBox1.Width - 1);
                int y = rnd.Next(pictureBox1.Height - 1);
                food[x, y] = true;
                ChangedColorOfPixel(new Coord(x, y), Color.Red);
            }


        }
        public void ChangedColorOfPixel(Coord coord, Color color)
        {
            front.SetPixel(coord.X, coord.Y, color);
        }
    }
}
