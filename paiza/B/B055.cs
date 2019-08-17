using System;
using System.Collections.Generic;
using System.Linq;
class solution
{
    static void Main(string[] args)
    {
        List<string> strall = new List<string>();
        while (true)
        {
            string str = Console.ReadLine();
            if (str == null) break;
            strall.Add(str);
        }
        string[] strnx = strall[0].Split(' ');
        int n = int.Parse(strnx[0]);
        int x = int.Parse(strnx[1]);
        strall.Remove(strall[0]);
        List<int> anslist = new List<int>();

        for (int i = 0; i < n; ++i)
        {
            List<string> abcdlist = new List<string>();
            string[] strabcd = strall[i].Split(' ');
            int a = int.Parse(strabcd[0]);
            int b = int.Parse(strabcd[1]);
            int c = int.Parse(strabcd[2]);
            int d = int.Parse(strabcd[3]);
            if (x < a)
            {
                anslist.Add(b);
            }
            else
            {
                int m = 1;
                while (true)
                {
                    if (x < a + c * m)
                    {
                        anslist.Add(b + d * m);
                        break;
                    }
                    ++m;
                }
            }
        }
        int ansmax = anslist.Max();
        int ansmin = anslist.Min();
        Console.WriteLine(ansmin + " " + ansmax);

    }
}