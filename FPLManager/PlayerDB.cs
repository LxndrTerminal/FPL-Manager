using System;

namespace FPL.Manager;


public class PlayerDB
{
    public List<Player> players = new List<Player>();

    public PlayerDB()
    {
        SetPlayers();
    }
    public void SetPlayers()
    {
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

        players.Add(player1);
        players.Add(player2);
        players.Add(player3);   
    }

    public bool PlayerExists(Player player)
    {
        return players.Contains(player);
    }

    

}