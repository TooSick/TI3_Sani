using System;
using System.Numerics;

namespace TI3
{
    public class AlgorithmRSA
    {
        public long p { get; private set; }
        public long q { get; private set; }
        public long r { get; private set; }
        public long e { get; private set; }
        public long d { get; private set; }

        public AlgorithmRSA()
        {
            Initialize();
        }

        
        private void Initialize()
        {
            p = Simple.Create();
            q = Simple.Create();

            r = p * q;

            var f = (p - 1) * (q - 1);

            e = PublicKey(f);
            d = PrivateKey(e, f);
        }

        private static long PublicKey(long f)
        {
            long e = f - 1;

            while (true)
            {
                if (Simple.SimpleNumber(e) &&
                    e < f &&
                    BigInteger.GreatestCommonDivisor(new BigInteger(e), new BigInteger(f)) == BigInteger.One)
                    break;
                e--;
            }

            return e;
        }

        private static long PrivateKey(long a, long n)
        {
            long d0 = n;
            long d1 = a;
            long y0 = 0;
            long y1 = 1;

            while (d1 > 1)
            {
                long q = d0 / d1;
                long d2 = d0 % d1;
                long y2 = y0 - q * y1;
                d0 = d1;
                d1 = d2;
                y0 = y1;
                y1 = y2;
            }

            return y1 < 0 ? y1 + n : y1;
        }

       
        public static BigInteger Exp(BigInteger a, BigInteger z, BigInteger n)
        {
            BigInteger a0 = a, z0 = z, x = 1;
            while (z0 != 0)
            {
                while (z0 % 2 == 0)
                {
                    z0 = z0 / 2;
                    a0 = (a0 * a0) % n;
                }

                z0 = z0 - 1;
                x = (x * a0) % n;
            }

            return x;
        }
    }
}

