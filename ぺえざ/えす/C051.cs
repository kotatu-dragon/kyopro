using System;
using System.Linq;
namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            string[] line1 = System.Console.ReadLine().Trim().Split(' ');
            int[] line2 = line1.Select(s => int.Parse(s)).ToArray();
            Array.Sort(line2);
            string[] line3 = line2.Select(x => x.ToString()).ToArray();
            string left1 = line3[3] + line3[0];
            string right1 = line3[2] + line3[1];
            int left2 = Int32.Parse(left1);
            int right2 = Int32.Parse(right1);
            System.Console.WriteLine(left2 + right2);
        }
    }
}
