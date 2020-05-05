using JustLudo.Common;
using JustLudo.Figures.Contracts;

namespace JustLudo.Board.Contracts
{
    public interface IBoard
    {
        int TotalRows { get; }

        int TotalCols { get; }

        void AddFigure(IFigure figure, Position position);

        void RemoveFigure(Position position);

        IFigure GetFigureAtPosition(Position position);
        
    }
}
