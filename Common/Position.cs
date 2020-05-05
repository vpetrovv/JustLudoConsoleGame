namespace JustLudo.Common
{
    public struct Position
    {
        public static Position FromArrayCoordinates(int arrRow, int arrCol)
        {
            return new Position(arrRow , arrCol );
        }
        public Position(int row, int col)
            :this()
        {
            this.Row = row;
            this.Col = col;
            
        }
        public int Row { get; private set; }

        public int Col { get; private set; }

    }
}
