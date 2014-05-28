using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diophantine_equation
{
    class Program
    {
        public static int numOfVariables = 0;
        public static int[] coefficients;
        public static int resOfEquation = 0;
        public static int[][] gens = new int[5][];
        public static int[] rates = new int[5];
        public static float[] pers = new float[5];
        public static float reversSum = 0;

        static void Main(string[] args)
        {
            //ввод данных
            Random rnd = new Random();
            Console.WriteLine("Enter the number of variables");
            while (!int.TryParse(Console.ReadLine(), out numOfVariables)) Console.WriteLine("Please enter the number of variables.");
            Console.WriteLine("Enter the coefficients for each variable, separated by spaces.");
            bool flag = true;
            while (flag)
            {
                string coef = Console.ReadLine();
                string[] split = coef.Split(new Char[] { ' ' });
                if (split.Length != numOfVariables)
                {
                    Console.WriteLine("Please enter the coefficients for each variable, separated by spaces.");
                    continue;
                }
                int i = 0;
                coefficients = new int[numOfVariables];
                foreach (string s in split)
                {
                    if (!int.TryParse(s, out coefficients[i]))
                    {
                        Console.WriteLine("Please enter the coefficients for each variable, separated by spaces.");
                        flag = true;
                        break;
                    }
                    else
                    {
                        ;
                        i++;
                        flag = false;
                    }
                }
            }
            Console.WriteLine("Enter the result of equation.");
            while (!int.TryParse(Console.ReadLine(), out resOfEquation)) Console.WriteLine("Please enter the result of equation.");

            //подсчет
            bool fl = true;
            CreatePopulation();
            while (fl)
            {
                CalculateSurvivalRates();
                if (rates[0] == 0 || rates[1] == 0 || rates[2] == 0 || rates[3] == 0 || rates[4] == 0)
                {
                    fl = false;
                    break;
                }
                foreach (int i in rates)
                {
                    reversSum = reversSum + (1 / (float)i);
                };
                CalculateProcant();
                Console.WriteLine(reversSum.ToString());
                int[] f = new int[5];
                int[] m = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    int[] p = ChosPair();
                    f[i] = p[0];
                    m[i] = p[1];
                }
                CreateNewPop(f, m);
                foreach(int[] gen in gens)
                {
                    int num = rnd.Next(100);
                    if (num < 3)
                    {
                        Mutate(gen);
                    }
                }
                Console.WriteLine("New population");
                foreach (int[] gen in gens)
                {
                    Console.Write('(');
                    foreach (int k in gen)
                        Console.Write(k.ToString() + ", ");
                    Console.WriteLine(')');
                }
                if(rates[0]==0 || rates[1]==0 || rates[2]==0 || rates[3]==0 || rates[4]==0)
                {
                    fl = false;
                }

            }
            Console.ReadKey();
        }
        static int[] ChosPair()
        {
            int[] pair = new int[2];
            int father = ChooseOne();
            int mather = ChooseOne();
            while(father==mather)
            {
                mather = ChooseOne();
            }
            pair[0] = father;
            pair[1] = mather;
            return pair;
        }
        static int ChooseOne()
        {
            Random rnd = new Random();
            int[] Val = CalVal();
            int randomNumber = rnd.Next(Val[4]);
            for(int i = 0; i<5; i++)
            {
                if (randomNumber < Val[i])
                {
                    return i;
                }
            }
            return 0;
            
        }
        static int[] CalVal ()
        {
            int[] Val = new int[5];
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    Val[i] += (int)(pers[k]*100);
                }
            }
            return Val;
        }
        static void CreateNewPop(int[] f, int[] m)
        {
            int[][] newPop = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                newPop[i] = GetNewGen(gens[f[i]], gens[m[i]]);
            }
            for (int i = 0; i < 5; i++)
            {
                gens[i] = newPop[i];
            }
            reversSum = 0;
        }
        static void CreatePopulation()
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int[] gen = new int[numOfVariables];
                for (int k = 0; k < numOfVariables; k++)
                {
                    gen[k] = rnd.Next(1, resOfEquation);
                }
                gens[i] = gen;
            }
            foreach (int[] gen in gens)
            {
                Console.Write('(');
                foreach (int k in gen)
                    Console.Write(k.ToString() + ", ");
                Console.WriteLine(')');
            }
        }
        static void CalculateSurvivalRates()
        {
            int k = 0;
            foreach (int[] gen in gens)
            {
                int rate = 0;
                for (int i = 0; i < numOfVariables; i++)
                {
                    rate = rate + gen[i] * coefficients[i];
                }
                Console.WriteLine("Rate = {0}", rate);
                rates[k] = Math.Abs(rate - resOfEquation);
                k++;
            }
        }
        static void CalculateProcant()
        {
            for(int i=0; i<5; i++)
            {
                pers[i] = (1 / (float)rates[i]) / reversSum;
                Console.WriteLine(pers[i].ToString());
            }
        }
        static int[] GetNewGen(int[] fGen, int[] mGen)
        {
            Random rnd = new Random();
            int[] childGen = new int[fGen.Length];
            int delimiter = rnd.Next(1, fGen.Length);
            for (int i = 0; i < delimiter; i++)
            {
                childGen[i] = fGen[i];
            }
            for (int i = delimiter; i < fGen.Length; i++)
            {
                childGen[i] = mGen[i];
            }
            return childGen;
        }
        static void Mutate(int[] gen)
        {
            Random rnd = new Random();
            int slotIndex = rnd.Next(numOfVariables);
            int inNumber = rnd.Next(1, resOfEquation);
            gen[slotIndex] = inNumber;
        }
    }
}
