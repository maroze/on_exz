using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Test
    {
        //GetLength(0) - возвращает количество строк 
        //GetLength(1) - возвращает количество столбцов

        //хули он делает, он передает в параметры двухмерный массив,
        //затем создает массив result с тем же кол-ом строк и столбцов
        //два цикла чтобы пройтись по двухм-ым массивам
        //в конце делает проверку если значения массива равны кол-ву строк,
        //то он заполняет массив result тем числом которое перелаем в параметр вторым
        public static int[,] Method(int[,]array,int value)
        {//1
            int[,] result = new int[array.GetLength(0), array.GetLength(1)];//2
            for (int i = 0; i < array.GetLength(0); i++)//3
            {
                for (int j = 0; j < array.GetLength(1); j++)//4
                {
                    if (array.GetLength(0) == array[i,j])//5
                    {
                        result[i, j] = value;//6
                    }
                    Console.WriteLine(result[i,j]) ;
                }
            }
            return result;//7
        }//8
    }
}
