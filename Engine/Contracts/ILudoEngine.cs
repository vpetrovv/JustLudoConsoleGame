namespace JustLudo.Engine.Contracts
{
    using JustLudo.Players.Contracts;
    using System.Collections.Generic;
 

    public interface ILudoEngine
    {
        IEnumerable<IPlayer> Players { get;  }


        void Initialize(IGameInitializationStrategy gameInitializationStrategy);

        void Start();

        void WinningConditions();

    }
}
