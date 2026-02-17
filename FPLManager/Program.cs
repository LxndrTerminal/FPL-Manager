using System;

namespace FPL.Manager;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to FPLManager...");
        Console.WriteLine("Let's set up your team!");
        Console.WriteLine("-------------------------\n\n");

        Player player1 = new Player();
        player1.Name = "Erling Haaland";
        player1.Position = "ST";
        player1.Price = 14;
        player1.Team = "MNC";
        player1.Points = 12;


        Player player2 = new Player();
        player2.Name = "Dominic Szobozlai";
        player2.Position = "CM";
        player2.Price = 8;
        player2.Team = "LIV";
        player2.Points = 10;

        Player player3 = new Player();
        player3.Name = "Gabriel";
        player3.Position = "DEF";
        player3.Price = 6;
        player3.Team = "ARS";
        player3.Points = 9;

        Console.WriteLine("Here are available players: ");
        Console.Write("1. ");
        player1.ViewPlayer();
        Console.Write("2. ");
        player2.ViewPlayer();
        Console.Write("3. ");
        player3.ViewPlayer();

        Console.WriteLine("To add player use number e.g. 1 adds Erling Haaland");

        string usrinput = Console.ReadLine();

        //TODO input validation, remove player option, view team option
        
    }
}

public class Player
{
    public string Name {get;set;}
    public int Price {get;set;}
    public string Team {get;set;}
    public int Points{get;set;}
    public string Position{get;set;}

    public void ViewPlayer()
    {
        Console.WriteLine(this.Position + "\n" + this.Name);
    }
}

public class Team
{
    public List<Player> Players {get;set;}
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

    public void AddPlayer(Player player)
    {
        Players.Add(player);
        Console.WriteLine(@"Added ", player.Name, " Successfully!");
    }

    public void RemovePlayer(Player player)
    {
        Players.Remove(player);
        Console.WriteLine(@"Removed ", player.Name, " Successfully!");
    }

    public void ViewTeam()
    {
        foreach (Player player in this.Players)
        {
            Console.WriteLine(player.Position + "\n" + player.Name);
            
        }
    }
}