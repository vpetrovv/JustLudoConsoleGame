namespace JustLudo.Players
{
    using System;
    using System.Collections.Generic;
    using JustLudo.Common;

    using JustLudo.Figures;
    using JustLudo.Figures.Contracts;
    using JustLudo.Players.Contracts;

    public class Player : IPlayer
    {
        private readonly ICollection<IFigure> figures;

        public Player(string name, LudoColor color)
        {
            // TODO: validate name length
            this.Name = name;
            this.figures = new List<IFigure>();
            this.Color = color;
        }

        public string Name { get; private set; }

        public LudoColor Color { get; private set; }

        public void AddFigure(IFigure figure)
        {
            ObjectValidator.CheckIfObjectIsNull(figure, GlobalErrorMessages.NullFigureErrorMessages);

            // TODO: check figure and player color
            this.CheckIfFigureExists(figure);
            this.figures.Add(figure);
        }

        public void RemoveFigure(IFigure figure)
        {
            ObjectValidator.CheckIfObjectIsNull(figure, GlobalErrorMessages.NullFigureErrorMessages);

            // TODO: check figure and player color
            this.CheckIfFigureDoesNotExist(figure);
            this.figures.Remove(figure);
        }

        private void CheckIfFigureExists(IFigure figure)
        {
            if (this.figures.Contains(figure))
            {
                throw new InvalidOperationException("This player already owns this figure!");
            }
        }

        private void CheckIfFigureDoesNotExist(IFigure figure)
        {
            if (!this.figures.Contains(figure))
            {
                throw new InvalidOperationException("This player does not own this figure!");
            }
        }
        void RollDice(int numberRolle)
        {
            int numberRolled = new Dice().Roll();
        }

        


    }
}
