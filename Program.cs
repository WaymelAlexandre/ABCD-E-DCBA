using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int ABCD = 0000;

            for (int i = 0; i < 9999; i++)
            {
                int A = ABCD / 10 / 10 / 10 % 10;
                int B = ABCD / 10 / 10 % 10;
                int C = ABCD / 10 % 10;
                int D = ABCD % 10;
                string DC = D + "" + C + "" + B + "" + A;
                int DCBA = int.Parse(DC);

                if (A < 5)
                {
                    if ((A != B && A != C && A != D && B != C && B != D && C != D))
                    {
                        for (int E = 1; E < 9; E++)
                        {
                            if (ABCD * E == DCBA)
                            {
                                System.Console.WriteLine(ABCD  + " * " + E + " = " + DCBA );
                            }
                        }
                    }
                }
                else
                {
                    // Blist.Add(i);
                }
                ABCD++;
            }

        }
    }
}



