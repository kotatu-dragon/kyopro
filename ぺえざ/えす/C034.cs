using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static void Main(string[] args)
    {
        string[] fomula = Console.ReadLine().Trim().Split(' ');
        var a = fomula[0];
        var o = fomula[1];
        var b = fomula[2];
        var c = fomula[4];

        if (c == "x")
        {
            int ia = Int32.Parse(a);
            int ib = Int32.Parse(b);
            if (o == "+")
            {
                Console.WriteLine(ia + ib);
            }
            else
            {
                Console.WriteLine(ia - ib);
            }
        }

        if (a == "x")
        {
            int ic = Int32.Parse(c);
            int ib = Int32.Parse(b);
            if (o == "+")
            {
                Console.WriteLine(ic - ib);
            }
            else
            {
                Console.WriteLine(ic + ib);
            }
        }

        if (b == "x")
        {
            int ia = Int32.Parse(a);
            int ic = Int32.Parse(c);
            if (o == "+")
            {
                Console.WriteLine(ic - ia);
            }
            else
            {
                Console.WriteLine(ia - ic);
            }
        }
    }
}