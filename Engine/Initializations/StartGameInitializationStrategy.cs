namespace JustLudo.Engine.Initializations
{
    using JustLudo.Board.Contracts;
    using JustLudo.Common;
    using JustLudo.Engine.Contracts;
    using JustLudo.Figures;
    using JustLudo.Players.Contracts;
    using System;
    using System.Collections.Generic;

    class StartGameInitializationStrategy : IGameInitializationStrategy
    {
        
        private const int TotalBoardRows= 13;
        private const int TotalBoardCols= 13;
        public void Initialize(IList<IPlayer> players, IBoard board)
        {
            this.ValidateStrategy(players, board);
            var firstPlayer = players[0];
            var secondPlayer = players[1];
            var thirdPlayer = players[2];
            var fourthPlayer = players[3];

            //first player figure position
            for (int i = 1; i < 3; i++)
            {
               for (int j = 1; j < 3; j++)
                {
                    var figure = new Figure(firstPlayer.Color);
                    firstPlayer.AddFigure(figure);
                    var position = new Position(i, j);
                   board.AddFigure(figure, position);
               }
            }
            //second player 
            for (int i = 1; i < 3; i++)
            {
                for (int j = 12; j < 14; j++)
                {
                    var figure = new Figure(secondPlayer.Color);
                    secondPlayer.AddFigure(figure);
                    var position = new Position(i, j);
                    board.AddFigure(figure, position);
                }
            }
            ////third player figure position
            for (int i = 12; i < 14; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                  var figure = new Figure(thirdPlayer.Color);
                    thirdPlayer.AddFigure(figure);
                   var position = new Position(i, j);
                    board.AddFigure(figure, position);
                }
            }
            ////fourth player figure position
            for (int row = 12; row < 14; row++)
            {
                for (int col = 12; col < 14; col++)
               {
                    var figure = new Figure(fourthPlayer.Color);
                    fourthPlayer.AddFigure(figure);
                    var position = new Position(row, col);
                    board.AddFigure(figure, position);
                }
            }
        }

     
        public void ValidateStrategy(ICollection<IPlayer> players, IBoard board)
        {
              if (players.Count != GlobalConstants.NumberOfPLayer)
            {
                throw new InvalidOperationException("Standrt game must have four players");
    }

            if (board.TotalRows != TotalBoardRows || board.TotalCols != TotalBoardCols)
            {
                throw new InvalidOperationException("Standrt game needs 15x15 board");

}
        }
    }
}
