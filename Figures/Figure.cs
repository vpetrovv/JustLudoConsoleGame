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


		LudoColor getColor()
		{
			return color;
		}

		int getPieceNumber()
		{
			return figureNumber;
		}

		int getX()
		{
			return xCoord;
		}

		int getY()
		{
			return yCoord;
		}

		void setX(int x)
		{
			xCoord = x;
		}

		void setY(int y)
		{
			yCoord = y;
		}

		void setTakenOut(bool mode)
		{
			takenOut = mode;
		}

		bool isTakenOut()
		{
			return takenOut;
		}

		void setCompleted(bool mode)
		{
			completed = mode;
		}

		bool isCompleted()
		{
			return completed;
		}
	}
}
