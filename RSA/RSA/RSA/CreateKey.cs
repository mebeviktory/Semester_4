using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    class CreateKey
    {
        public long p = 0;
        public long q = 0;
        public long d = 0;
        private static long CreateSimpleNumber()
        {
            long N = 0;
            bool arg = true;
            Random rnd = new Random();
            while (arg)
            {
                N = rnd.Next(1000,3000);
                arg = !isSimple(N);
            }
            return N;

        }
        public void CreatePQ()
        {
            p = CreateSimpleNumber();
            q = CreateSimpleNumber();
        }
        public long nKeyCreate()
        {
            long n = p * q;
            return n;
        }
        public long eKeyCreate()
        {
            long m = (p - 1) * (q - 1);
            long e = getE(m);
            d = getD(e,m);
            return e;

        }
        private long getD(long e, long m)
        {
            long i = 2;
            while(true)
            {
                if ((i * e) % m == 1) return i;
                i++;
            }
            
        }
        private static long getE(long m)
        {
            for (long i = 113; i < m; i++)
            {
                if (GCD(i, m) == 1)
                    return i;
            }
            return 0;   // сделать ошибку!!!
        }
        private static long GCD(long a, long b)
        {
            long Remainder;
            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
        }
        private static bool isSimple(long N)
        {
            for (int i = 2; i <= (long)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }
    }
}
