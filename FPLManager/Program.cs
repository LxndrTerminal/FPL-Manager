using System;

namespace FPL.Manager;
class Program
{
    public static void Main()
    {
        Console.WriteLine("\n\n" + "Welcome to FPLManager...");
        Console.WriteLine("Let's set up your team!");
        Console.WriteLine("-------------------------\n\n");

        Player player1 = new Player();
        player1.PlayerID = 1;
        player1.Name = "Erling Haaland";
        player1.Position = "ST";
        player1.Price = 14;
        player1.Team = "MNC";
        player1.Points = 12;


        Player player2 = new Player();
        player2.PlayerID = 2;
        player2.Name = "Dominic Szobozlai";
        player2.Position = "CM";
        player2.Price = 8;
        player2.Team = "LIV";
        player2.Points = 10;

        Player player3 = new Player();
        player3.PlayerID = 3;
        player3.Name = "Gabriel";
        player3.Position = "DEF";
        player3.Price = 6;
        player3.Team = "ARS";
        player3.Points = 9;

        Team team = new Team();
        team.Space = 2;
        team.Budget = 100;


        List<Player> players = new List<Player>();
        players.Add(player1);
        players.Add(player2);
        players.Add(player3);



        //TODO input validation, remove player option
        do
        {
            team.BudgetRemaining();
            Console.WriteLine("Here are available players: ");            
            foreach (Player player in players)
            {
                player.ViewPlayer();
            }
            Console.WriteLine("To add player use player ID e.g. 1 adds Erling Haaland");

            string usrinput = Console.ReadLine();
            
            switch (usrinput)
            {
                case "1":
                    team.AddPlayer(player1);
                    players.Remove(player1);
                    break;
                case "2":
                    team.AddPlayer(player2);
                    players.Remove(player2);
                    break;
                case "3":
                    team.AddPlayer(player3);
                    players.Remove(player3);
                    break;
                default:
                    Console.WriteLine("Incorrect player ID");
                    break;
            }


        
        } while (team.HasSpace());


        Console.WriteLine("Whats a team without a name? Please name your team: ");
        team.Name = Console.ReadLine();
        
        Console.WriteLine("Great! Here is your team.");

        team.ViewTeam();    
        team.BudgetRemaining();
    }
}

public class Player
{
    public int PlayerID {get;set;}
    public string Name {get;set;}
    public int Price {get;set;}
    public string Team {get;set;}
    public int Points{get;set;}
    public string Position{get;set;}

    public void ViewPlayer()
    {
        Console.WriteLine(this.PlayerID + " " + this.Position + "\n" + this.Name);
    }
}

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

    public void BudgetRemaining()
    {
        Console.WriteLine("Money in the bank: R" + Budget);
    }
}