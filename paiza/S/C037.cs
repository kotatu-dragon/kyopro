using System;
using System.Collections.Generic;
using System.Linq;
class solution
{
    static void Main(string[] args)
    {
        string all = Console.ReadLine();
        string[] day_time = all.Split(' ');
        string[] MD = day_time[0].Split('/');
        string[] HM = day_time[1].Split(':');
        int D = int.Parse(MD[1]);
        int H = int.Parse(HM[0]);
        if (H > 24)
        {
            while (true)
            {
                H = H - 24;
                D = D + 1;
                if (H < 24) break;
            }
        }
        if (H > 9)
        {
            Console.WriteLine(MD[0] + "/" + D + " " + H + ":" + HM[1]);
        }
        else
        {
            Console.WriteLine(MD[0] + "/" + D + " " + "0" + H + ":" + HM[1]);
        }
    }
}