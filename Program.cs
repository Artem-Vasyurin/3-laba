using System;

namespace Test_vdego
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArroy = { 1, 4, 6, 2 };
            Delete(ref myArroy, 2);

           // LastDel(ref myArroy);
        }

        static void Delete(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            
            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index; i < array.Length-1; i ++)
                newArray[i] = array[i+1];
            array = newArray;
        }

        static void FirstDel(ref int[] array)
        {
            Delete(ref array, 0);
        }

        static void LastDelete(ref int[] array)
        {
            Delete(ref array, array.Length-1);
        }
    }
}
