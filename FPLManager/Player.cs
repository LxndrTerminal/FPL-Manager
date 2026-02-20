using System;

namespace FPL.Manager;

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