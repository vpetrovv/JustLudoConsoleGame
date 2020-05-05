namespace JustLudo.Board
{
    using System;
    using JustLudo.Common;
    using JustLudo.Board.Contracts;
    using JustLudo.Figures.Contracts;
    using System.Collections.Generic;


    public class Board : IBoard
    {
        private readonly IFigure[,] board;
       
        

        public Board(int rows = GlobalConstants.StandrdGameTotalBoardCols, int cols = GlobalConstants.StandrdGameTotalBoardCols)
        {
            this.TotalRows = rows;
            this.TotalCols = cols;
            this.board = new IFigure[rows, cols];
        }

     

        public int TotalRows { get; private set; }

        public int TotalCols { get; private set; }
        
      

        public void AddFigure(IFigure figure, Position position)
        {
            ObjectValidator.CheckIfObjectIsNull(figure, GlobalErrorMessages.NullFigureErrorMessages);
            CheckIfPositionIsValid(position);
        }

        public void RemoveFigure(Position position)
        {

            this.CheckIfPositionIsValid(position);

            int arrRow = this.GetArrayRow(position.Row);
            int arrCol = this.GetArrayCol(position.Col);
             this.board[arrRow, arrCol]=null;
        }

        public IFigure GetFigureAtPosition(Position position)
        {
            int arrRow = this.GetArrayRow(position.Row);
            int arrCol = this.GetArrayCol(position.Col);
            return this.board[arrRow, arrCol];
        }


        private int GetArrayRow(int ludoRow)
        {
            return this.TotalRows;
        }
        private int GetArrayCol(int ludoCol)
        {
            return this.TotalCols;
        }


        private void CheckIfPositionIsValid(Position position)
        {
            if (position.Row < 1 || position.Row > GlobalConstants.StandrdGameTotalBoardRows)
            {
                throw new IndexOutOfRangeException("Selected row position is not valid");
            }

            if (position.Col < 1 || position.Col > GlobalConstants.StandrdGameTotalBoardCols)
            {
                throw new IndexOutOfRangeException("Selected column position is not valid");

            }
        }

        
    }
}
