using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExercices
{
    public static class Swapper
    {
        public static void Swap<T>(ref T arg1, ref T arg2)
        {
            var tmp = arg1;
            arg1 = arg2;
            arg2 = tmp;
        }

        public static void Swap<T>(T[] array, int index1, int index2)
        {
            (array[index2], array[index1]) = (array[index1], array[index2]);
        }

        public static void Swap<T>(IList<T> list, int index1, int index2)
        {
            var tmp = list[index1];
            list[index1] = list[index2];
            list[index2] = tmp;
        }
    }
}
