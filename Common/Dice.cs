namespace JustLudo.Common
{
    using System;

    public  class Dice
    {
        public int Roll()
        {
            return new Random().Next(1, 7);
        }

        
    }
}
