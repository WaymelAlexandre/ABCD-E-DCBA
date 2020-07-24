using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int ABCD = 0;
            for (int i = 0; i < 5000; i++)  
            {
                int A = ABCD / 10 / 10 / 10 % 10;
                int B = ABCD / 10 / 10 % 10;
                int C = ABCD / 10 % 10;
                int D = ABCD % 10;
                int DCBA = int.Parse(D + "" + C + "" + B + "" + A);
                
                if ((A != B && A != C && A != D && B != C && B != D && C != D))
                {
                    for (int E = 2; E < 9; E++)
                    {
                        if (ABCD * E == DCBA)
                        {
                            System.Console.WriteLine(ABCD + " * " + E + " = " + DCBA);
                        }
                    }
                }
                ABCD++;
            }
        }
    }
}



