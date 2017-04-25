using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBubbleSorter
{

    public class BubbleSorter
    {
        public delegate bool Comparison(object x, object y);
        public static void Sort(object[] sortArray, Comparison comparison)
        {
            for (int i = 0; i < sortArray.Length; i++)
            {
                for (int j = i + 1; j < sortArray.Length; j++)
                {
                    if (comparison(sortArray[j], sortArray[i]))
                    {
                        object temp = sortArray[i];
                        sortArray[i] = sortArray[j];
                        sortArray[j] = temp;

                    }
                }
            }
        }
    }
}
