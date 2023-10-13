using System;

namespace Programming
{
    internal class BinaryGap
    {
        //how to test : call this mthod from Program.cs like eblow
        //var max= BinaryGap.FindMaxBinaryGap(1021);
        public static int FindMaxBinaryGap(int n)
        {
            if (n == 0 || n < 0)
            {
                return 0;
            }
            //convert to binary representation
            string binaryRepresentation = Convert.ToString(n, 2);
            int maxCountZeros = 0;
            int countZero = 0;
            var startOne = false;
            for (int i = 0; i < binaryRepresentation.Length; i++)
            {
                //check if it is binary 1 then increment it
                if (binaryRepresentation[i] != '1')
                {
                    countZero += 1;
                }
                //make the start flag true to begin the search of pattern like 1001
                else if (!startOne)
                {
                    startOne = true;
                }
                else
                {
                    //get the maximum count here
                    maxCountZeros = Math.Max(maxCountZeros, countZero);
                    countZero = 0;
                }

            }
            return maxCountZeros;
        }
    }
}
