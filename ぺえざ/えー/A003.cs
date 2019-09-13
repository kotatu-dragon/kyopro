using System;
using System.Collections.Generic;
using System.Linq;
class solution
{
    static void Main(string[] args)
    {
        string[,] board = new string[10, 10];

        board[4, 4] = "W";
        board[4, 5] = "B";
        board[5, 4] = "W";
        board[5, 5] = "B";
        List<string> all = new List<string>();
        while (true)
        {
            string s = Console.ReadLine();
            if (s == null) break;
            all.Add(s);
        }
        string sN = all[0];
        int N = int.Parse(sN);
        all.Remove(all[0]);
        for (int i = 0; i < N; ++i)
        {
            string[] turn = all[i].Split(' ');
            string color = turn[0];
            int y = int.Parse(turn[1]);
            int x = int.Parse(turn[2]);
            board[y, x] = color;
            int[] diry = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dirx = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };
            for (int k = 0; k < diry.Length; ++k)
            {
                y = int.Parse(turn[1]);
                x = int.Parse(turn[2]);
                List<int> runy = new List<int>();
                List<int> runx = new List<int>();
                y = y + diry[k];
                x = x + dirx[k];
                if (board[y, x] != color && board[y, x] != null)
                {
                    while (true)
                    {
                        if (board[y, x] == color)
                        {
                            for (int p = 0; p < runy.Count; ++p)
                            {
                                int ry = runy[p];
                                int rx = runx[p];
                                board[ry, rx] = color;
                            }
                            break;
                        }
                        if (board[y, x] == null) break;
                        else
                        {
                            runy.Add(y);
                            runx.Add(x);
                            y = y + diry[k];
                            x = x + dirx[k];
                        }
                    }
                }

            }
        }
        int BC = 0;
        int WC = 0;
        foreach (string i in board)
        {
            if (i == "B")
            {
                BC = BC + 1;
            }
            if (i == "W")
            {
                WC = WC + 1;
            }
        }
        string iBC = BC.ToString("D2");
        string iWC = WC.ToString("D2");
        if (BC > WC)
        {
            Console.WriteLine(iBC + "-" + iWC + " The black won!");
        }
        else if (WC > BC)
        {
            Console.WriteLine(iBC + "-" + iWC + " The white won!");
        }
        else
        {
            Console.WriteLine(iBC + "-" + iWC + " Draw!");
        }
    }
}
