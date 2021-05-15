using System;
using System.Numerics;

namespace TI3
{
    public static class EDS
    {
        
        public static BigInteger Hash(string mes, BigInteger p, BigInteger q, BigInteger h)
        {
            var r = p * q;

            foreach (var m in mes)
            {
                h = AlgorithmRSA.Exp(h + m, 2, r);
            }

            return h;
        }
    }
}
