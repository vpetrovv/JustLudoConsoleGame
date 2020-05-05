namespace JustLudo.Engine.Contracts
{
    using JustLudo.Board.Contracts;
    using JustLudo.Players.Contracts;
    using System.Collections.Generic;

    public interface IGameInitializationStrategy
    {
        void Initialize(IList<IPlayer> players, IBoard board);
    }
}
