using System;

namespace FPL.Manager;

public class Team
{
    public string Name {get;set;}
    public List<Player> Players = new List<Player>();
    public int Points
    {
        get
        {
            int totalPoints = 0;
            foreach (Player player in this.Players)
            {
                totalPoints += player.Points;
            }
            return totalPoints;
        }
    }
    public int Budget {get; set;}

    public int Space {get;set;}

    public void AddPlayer(Player player)
    {

        if (Players.Contains(player))
        {
            Console.WriteLine("No duplications!");
            return;
        }
        if (Space > 0)
        {
            Players.Add(player);
            Budget -= player.Price;
            Space -= 1;
            Console.WriteLine(@"Added ", player.Name, " Successfully!");
    
        }
        else
        {
            Console.WriteLine("Unable to add player, Max Capacity reached!");
        }
        }

    public void RemovePlayer(Player player)
    {
        if (!Players.Contains(player))
        {
            Console.WriteLine("This player is not in your team!");
            return;
        }
        Players.Remove(player);
        Budget += player.Price;
        Space += 1;
        Console.WriteLine(@"Removed ", player.Name, " Successfully!");
    }

    public bool HasSpace()
    {
        return Space > 0;
    }

    public void ViewTeam()
    {
        Console.WriteLine("\n\n" + Name + "\n\n");
        foreach (Player player in this.Players)
        {
            Console.WriteLine(player.Position + "\n" + player.Name);
            
        }
    }

    public bool HasPlayers()
    {
        return Players.Count>0;
    }

    public bool PlayerExists(Player player)
    {
        return Players.Contains(player);
    }

    public void BudgetRemaining()
    {
        Console.WriteLine("Money in the bank: R" + Budget);
    }
}