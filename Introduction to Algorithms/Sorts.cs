using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Algorithms
{
    class Sorts
    {

        static void InsertionSort(IComparable[] list)
        {
            for (int j = 1 ; j < list.Length; j++)
            {
                IComparable key = list[j];
                int i = j - 1;
                while (i >= 0 && list[i].CompareTo(key) > 0)
                {
                    list[i + 1] = list[i];
                    i = i - 1;
                }
                list[i + 1] = key;
            }
        }

    }
}
