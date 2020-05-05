namespace JustLudo.Figures
{
    using JustLudo.Common;
    using JustLudo.Figures.Contracts;

    public class Figure : IFigure
    {
		private int figureNumber;
		private int xCoord;
		private int yCoord;
		 LudoColor color;
		private bool takenOut;
		private bool completed;

		

		public Figure( LudoColor color)
		{

			
			this.Color = color;

		}
		public LudoColor Color { get; private set; }


		
	}
}
