using System;
using System.Numerics;
using System.Security.Cryptography;

namespace TI3
{
    public static class Simple
    {
        private static readonly Random Random = new Random();

        
        public static long Create()
        {
            const int min = 1000, max = 10000;
            long Num;

            while (true)
            {
                Num = Random.Next(min, max);
                if (SimpleNumber(Num))
                    break;
            }

            return Num;
        }

       
        public static bool SimpleNumber(long Num)
        {
            const int con = 10;

            if (!MillerRabin(Num, con)) return false;

            for (long i = 2; i <= Math.Sqrt(Num); i++)
                if (Num % i == 0)
                    return false;

            return true;
        }

        
        private static bool MillerRabin(BigInteger n, int v)
        {
            if (n == 2 || n == 3)
                return true;

            if (n < 2 || n % 2 == 0)
                return false;

            BigInteger d = n - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            var RNG = new RNGCryptoServiceProvider();
            for (int i = 0; i < v; i++)
            {
                byte[] Array = new byte[n.ToByteArray().LongLength];

                BigInteger a;

                do
                {
                    RNG.GetBytes(Array);
                    a = new BigInteger(Array);
                } while (a < 2 || a >= n - 2);

                BigInteger x = BigInteger.ModPow(a, d, n);

                if (x == 1 || x == n - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);

                    if (x == 1)
                        return false;

                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                    return false;
            }

            return true;
        }
    }
}
