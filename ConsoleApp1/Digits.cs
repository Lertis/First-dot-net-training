using System.Collections.Generic;

namespace ConsoleDigits
{
    class Digits
    {

    public List<int> GetDigitsByLength(int length)
        {
            List<int> digits = new List<int>();
            for (int i = 0; i < length; i++)
            {
                digits.Add(i);
            }
            return digits;
        }
    }
}
