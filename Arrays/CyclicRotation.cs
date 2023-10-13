using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class CyclicRotation
    {
        //how to test this: call this method from program.cs
        //int[] n= { 3, 8, 9, 7, 6};
        //var rotatedArray = CyclicRotation.RotateArray(n, 3);
        public static int[] RotateArray(int[] A, int K)
        {
            var rotateArray = new int[A.Length];
            if(rotateArray.Length > 0)
            {
                for (int i = 0, j= A.Length-(K%A.Length); i < A.Length; i++)
                {
                    rotateArray[i] = A[(j + i) % A.Length];
                }
            }
            return rotateArray;
        }
    }
}
