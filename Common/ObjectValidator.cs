using System;

namespace JustLudo.Common
{
   public static class ObjectValidator
    {
        public static void CheckIfObjectIsNull(object obj, string errorMessages = GlobalConstants.EmptyString)
        {
            if (obj == null)
            {
                throw new NullReferenceException(GlobalErrorMessages.NullFigureErrorMessages);
            }
        }

    }
}
