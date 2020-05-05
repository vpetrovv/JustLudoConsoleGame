
namespace JustLudo.Engine
{
    using JustLudo.Board;
    using JustLudo.Board.Contracts;
    using JustLudo.Common;
    using JustLudo.Engine.Contracts;
    using JustLudo.InputProviders.Contracts;
    using JustLudo.Players;
    using JustLudo.Players.Contracts;
    using JustLudo.Renderers.Contracts;
    using System;
    using System.Collections.Generic;

    public class StandardFourPlayerEngine : ILudoEngine
    {
        private readonly IEnumerable<IPlayer> players;
        private readonly IRenderer renderer;
        private readonly IInputProvider input;
        private readonly IBoard board;

        public StandardFourPlayerEngine(IRenderer renderer,IInputProvider inputProvider)
        {
            this.renderer = renderer;
            this.input = inputProvider;
            this.board = new Board();
        }



        public void Initialize(IGameInitializationStrategy gameInitializationStrategy)
        {
            //TODO
            var players = new List<IPlayer>
            {
                new Player("pesho",LudoColor.Blue),
                new Player("gosho",LudoColor.Green),
                new Player("valio",LudoColor.Red),
                new Player("ivan",LudoColor.Yellow)

            };
                this.input.GetPlayers(GlobalConstants.NumberOfPLayer);
            gameInitializationStrategy.Initialize(players, this.board);
            this.renderer.RenderBoard(board);
        }

        public void Start()
        {
            throw new System.NotImplementedException();
        }

        public void WinningConditions()
        {
            throw new System.NotImplementedException();
        }



        public IEnumerable<IPlayer> Players
        {
            get
            {
                return new List<IPlayer>(this.players);
            }
        }
    }
}
