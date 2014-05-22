using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beetles
{
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
            public Genotype Mutation()
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
            Genotype newGen =new Genotype(upPoint, rightPoint, downPoint);
            return newGen;

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
}
