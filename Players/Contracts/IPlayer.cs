namespace JustLudo.Players.Contracts
{
    using JustLudo.Common;
    using JustLudo.Figures.Contracts;

    public interface IPlayer
    {
        string Name { get; }

        LudoColor Color { get; }

        void AddFigure(IFigure figure);

        void RemoveFigure(IFigure figure);
    }
}
