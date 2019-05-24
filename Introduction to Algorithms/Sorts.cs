using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Algorithms
{
    public class Sorts
    {

        public static IList<T> InsertionSort<T>(IList<T> list) where T : IComparable<T>
        {
            for (int j = 1 ; j < list.Count; j++)
            {
                T key = list[j];
                int i = j - 1;
                while (i >= 0 && list[i].CompareTo(key) > 0)
                {
                    list[i + 1] = list[i];
                    i = i - 1;
                }
                list[i + 1] = key;
            }
            return list;
        }

    }
}
