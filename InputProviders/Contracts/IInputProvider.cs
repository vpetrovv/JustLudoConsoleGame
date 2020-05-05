namespace JustLudo.InputProviders.Contracts
{
    using JustLudo.Players.Contracts;
    using System.Collections.Generic;

    public interface IInputProvider
    {
        IList<IPlayer> GetPlayers(int numberOfPlayers);
       
    }
}
