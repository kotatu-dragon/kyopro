using System;
using System.Collections.Generic;
using System.Linq;
class solution
{
    static void Main(string[] args)
    {
        List<string> all = new List<string>();
        while (true)
        {
            string str = Console.ReadLine();
            if (str == null) break;
            all.Add(str);
        }
        int N = int.Parse(all[0]);
        all.Remove(all[0]);
        int ans = 0;

        for (int i = 0; i < N; ++i)
        {
            string[] strt_N1 = all[i].Split(' ');
            List<string> strt_N = new List<string>();
            strt_N.AddRange(strt_N1);
            if (strt_N[0] == "s")
            {
                strt_N.Remove(strt_N[0]);
                int[] sN = strt_N.Select(int.Parse).ToArray();
                int sNS = sN.Sum();
                if (sNS > 349)
                {
                    int N2 = sN[1] + sN[2];
                    if (N2 > 159)
                    {
                        ans = ans + 1;
                    }
                }
            }
            else
            {
                strt_N.Remove(strt_N[0]);
                int[] lN = strt_N.Select(int.Parse).ToArray();
                int lNS = lN.Sum();
                if (lNS > 349)
                {
                    int N2 = lN[3] + lN[4];
                    if (N2 > 159)
                    {
                        ans = ans + 1;
                    }
                }
            }
        }
        Console.WriteLine(ans);
    }
}