using System;

namespace FPL.Manager;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("\n\n" + "Welcome to FPLManager...");
        Console.WriteLine("Let's set up your team!");
        Console.WriteLine("-------------------------\n\n");

        

        Team team = new Team();
        team.Space = 2;
        team.Budget = 100;

        PlayerDB playerDB = new PlayerDB();

        List<Player> players = playerDB.players;


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
            int input = 0;
            if(!int.TryParse(usrinput, out input))
            {
                Console.WriteLine("Player does not exists! ");
                continue;
            }

            Player player2add = players.FirstOrDefault(p=>p.PlayerID==input);
            
            if(!playerDB.PlayerExists(player2add))
                {
                    Console.WriteLine("Player does not exists! ");
                    continue;
                }
            players.Remove(player2add);
            team.AddPlayer(player2add);
        
        } while (team.HasSpace());


        Console.WriteLine("Whats a team without a name? Please name your team: ");
        team.Name = Console.ReadLine();
        
        Console.WriteLine("Great! Here is your team.");

        team.ViewTeam();    
        team.BudgetRemaining();


        Console.WriteLine("\nWould you like to remove a player? (y/N)\n");

        string userinput = Console.ReadLine();

        if (userinput.ToLower().Equals("y"))
        {
            do
            {
                Console.WriteLine("Which player would you like to remove (Use player id, quit to stop)?: \n");
                team.ViewTeam();
                userinput = Console.ReadLine();

                if (userinput == null)
                {
                    continue;
                }

                if (userinput.ToLower().Equals("quit"))
                {
                  break;  
                } 

            int input = 0;
            if(!int.TryParse(userinput, out input))
            {
                Console.WriteLine("Player does not exists! ");
                continue;
            }

            Player player2remove = team.Players.FirstOrDefault(p=>p.PlayerID==input);

            if(!team.PlayerExists(player2remove))
                {
                    Console.WriteLine("Player does not exists! ");
                }

            team.RemovePlayer(player2remove);


            }while(team.HasPlayers());
        }


    } 
}