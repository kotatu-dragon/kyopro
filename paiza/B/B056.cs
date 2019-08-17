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
            string a = Console.ReadLine();
            if (a == null) break;
            all.Add(a);
        }
        string sMN = all[0];
        string[] MN = sMN.Split(' ');
        int N = Int32.Parse(MN[1]);
        all.Remove(all[0]);
        int ans = 0;
        List<int> combo = new List<int>();
        List<string> D = new List<string>();
        List<string> P = new List<string>();
        for (int i = 0; i < N; ++i)
        {
            string[] dp = all[i].Split(' ');
            string d = dp[0];
            string p = dp[1];
            D.Add(d);
            P.Add(p);
        }
        for (int i = 0; i < N; ++i)
        {
            if (D[i] == P[i])
            {
                ans = ans + 1;
                combo.Add(ans);

            }
            else
            {
                if (D[i].Contains('#'))
                {
                    if (!D[i + 1].Contains('#'))
                    {
                        string d2 = D[i].Replace('#', '+');
                        if (d2 == P[i])
                        {
                            ans = ans + 1;
                            combo.Add(ans);
                        }
                        else
                        {
                            combo.Add(ans);
                            ans = 0;
                        }
                    }
                    else
                    {
                        string d2 = D[i].Replace('#', '+');
                        if (d2 == P[i])
                        {
                            List<string> snum = new List<string>();
                            List<string> subP = new List<string>();
                            int sans = ans;
                            while (true)
                            {
                                if (!D[i + 1].Contains('#')) break;
                                string d3 = D[i + 1].Replace('#', '+');
                                snum.Add(d3);
                                subP.Add(P[i + 1]);
                                ++i;
                                sans = sans + 1;
                            }
                            if (snum != subP)
                            {
                                int a = 0;
                                sans = ans;
                                while (true)
                                {
                                    if (snum[a] != subP[a]) break;
                                    sans = sans + 1;
                                }
                                combo.Add(sans);
                            }
                            else
                            {
                                ans = sans;
                                combo.Add(ans);
                            }
                        }
                    }
                }
                else
                {
                    combo.Add(ans);
                    ans = 0;
                }
            }
        }
        int result = combo.Max();
        Console.WriteLine(result);
    }
}