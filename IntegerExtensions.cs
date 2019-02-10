using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            // put your code here
            // throw new NotImplementedException();
            checked
            {
                if (a == 0 && b == 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    while (b != 0)
                        b = a % (a = b);
                    return Math.Abs(a);
                }
            }
        }
    }
}
