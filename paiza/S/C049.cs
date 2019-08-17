using System;
using System.Collections.Generic;
using System.Linq;
namespace solution
{
    class solution
    {
        static void Main(string[] args)
        {
            var strlist = new List<string>();
            while (true)
            {
                string floor = Console.ReadLine();
                if (floor == null) break;
                strlist.Add(floor);
            }

            List<int> list = strlist.ConvertAll(x => int.Parse(x));
            int N = list[0];

            int s1 = (1 - list[1]) * (-1);

            int s;
            var slist = new List<int>();
            for (var i = 1; i < N; i++)
            {
                s = list[i] - list[i + 1];
                if (s < 0)
                {
                    s = s * (-1);
                }
                slist.Add(s);
            }

            int ans = s1 + slist.Sum();

            Console.WriteLine(ans);

        }
    }
}