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
            string s = Console.ReadLine();
            if (s == null) break;
            all.Add(s);
        }
        int n = int.Parse(all[0]);
        all.Remove(all[0]);
        int ans = 0;
        for (int i = 0; i < n; ++i)
        {
            string[] qa = all[i].Split(' ');
            int q = qa[0].Length;
            int a = qa[1].Length;
            if (q == a)
            {
                if (qa[0] == qa[1])
                {
                    ans = ans + 2;
                }
                else
                {
                    List<string> Q = new List<string>();
                    List<string> A = new List<string>();
                    int sm = 0;
                    foreach (char c in qa[0])
                    {
                        string sc = c.ToString();
                        Q.Add(sc);
                    }
                    foreach (char c in qa[1])
                    {
                        string sc = c.ToString();
                        A.Add(sc);
                    }
                    for (int k = 0; k < q; ++k)
                    {
                        if (Q[k] != A[k])
                        {
                            sm = sm + 1;
                        }
                    }
                    if (sm == 1)
                    {
                        ans = ans + 1;
                    }
                    else
                    {
                        ans = ans + 0;
                    }
                }
            }
            else
            {
                ans = ans + 0;
            }
        }
        Console.WriteLine(ans);
    }
}