using System.Collections.Generic;

namespace Sum
{
    public class SumMethod
    {
        public static int SumUp(List<int> listOfNumbers)
        {                  
            int baseNumber = 0;

            for (int i = 0; listOfNumbers.Count > i; i++)
            {                                 
                baseNumber += listOfNumbers[i];
            }
            return baseNumber;
        }
    }
}
