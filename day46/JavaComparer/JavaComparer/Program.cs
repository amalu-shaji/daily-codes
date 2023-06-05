using System;
using System.Collections.Generic;

public class Player
{
    public string Name { get; set; }
    public int Score { get; set; }
}

public class Checker : IComparer<Player>
{
    public int Compare(Player a, Player b)
    {
        if (a.Score == b.Score)
        {
            return string.Compare(a.Name, b.Name, StringComparison.Ordinal);
        }
        else
        {
            return b.Score.CompareTo(a.Score);
        }
    }
}

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Player[] players = new Player[n];
        Checker checker = new Checker();

        for (int i = 0; i < n; i++)
        {
            string[] playerInfo = Console.ReadLine().Split(' ');
            players[i] = new Player { Name = playerInfo[0], Score = int.Parse(playerInfo[1]) };
        }

        Array.Sort(players, checker);

        foreach (Player player in players)
        {
            Console.WriteLine($"{player.Name} {player.Score}");
        }
    }
}
