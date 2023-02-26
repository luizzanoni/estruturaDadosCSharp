// array

// Value => 7, 11, 6, 55, 98, 45, 16, 96, 46
// Index => 0, 1, 2, 3, 4, 5 6, 7, 8 (são de 8 posições caso colocar mais ele retorna erro!)

using System;

namespace Dotnet.Array
{
    public static class ArrayDS
    {
        public static int[] ReserveArray(int[] array)
        {
            //Declaro aqui um novo array
            int[] reverseArray = new int[array.Lenght];

            //Variável para controlar posições do array
            int position = 0;

            for (int index = array.Lenght - 1 ; index >= 0; index--)
            {
                //populando um novo array
                reverseArray[position] = array[index];
                position++;
            }

            return reverseArray;
        }
    }
}