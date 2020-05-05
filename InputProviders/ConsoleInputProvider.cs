
namespace JustLudo.InputProviders
{
    using System;
    using JustLudo.Common;
    using JustLudo.Players;
    using JustLudo.Common.Console;
    using JustLudo.Players.Contracts;
    using System.Collections.Generic;
    using JustLudo.InputProviders.Contracts;
    

    public class ConsoleInputProvider :IInputProvider
    {
        private const string PlayerNameText = "Enter Player {0} name: ";
        
        public IList<IPlayer> GetPlayers(int numberOfPlayers)
        {
            var players = new List<IPlayer>();
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.Clear();
                ConsoleHelpers.SetCourserAtCenter( PlayerNameText.Length);
                Console.Write(string.Format(PlayerNameText, i));
                string name = Console.ReadLine();
                    


                var player = new Player(name, (LudoColor)(i - 1));
                players.Add(player);
            }
            return players;
        }

       
    }
}
