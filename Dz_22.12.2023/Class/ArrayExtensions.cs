using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_22._12._2023.Class
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Выводит массив, содержащий элементы исходного массива в квадрате
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] Square(this int[] array)
        {
            int[] squaredArray = new int[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                squaredArray[i] = array[i] * array[i];
            }
            return squaredArray;
        }

        /// <summary>
        /// Выводит массив, содержащий элементы исходного массива в кубе
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] Cube(this int[] array)
        {
            int[] cubedArray = new int[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                cubedArray[i] = array[i] * array[i] * array[i];
            }
            return cubedArray;
        }

        /// <summary>
        /// Высчитывает среднее значение из массива
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double Average(this int[] array)
        {
            if (array == null)
            {
                return Double.NaN;
            }
            else
            {
                double sum = 0;
                for (var i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return (sum / array.Length);
            }
        }

        /// <summary>
        /// Суммирует все элементы из масссива
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Sum(this int[] array)
        {
           int sum = 0;
           for (var i = 0; i < array.Length; i++)
           {
              sum += array[i];
           }
           return sum;
        }

        /// <summary>
        /// Выводит массив, состоящий из четных элементов исходного массива
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] Even(this int[] array)
        {
            return Array.FindAll(array, x => x % 2 == 0);
        }

        /// <summary>
        /// Выводит массив, состоящий из нечетных элементов исходного массива
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] Odd(this int[] array)
        {
            return Array.FindAll(array, x => x % 2 != 0);
        }
    }
}
