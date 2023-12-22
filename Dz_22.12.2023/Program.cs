using Dz_22._12._2023.Class;
using OneOf.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_22._12._2023
{
    internal class Program
    {
        // Задание 1
        static string PrintDiamond(int n)
        {
            if (n % 2 == 0 || n < 0)
            {
                return null;
            }

            string result = "";
            for (int i = 1; i <= n; i += 2)
            {
                result += new string(' ', (n - i) / 2) + new string('*', i) + "\n";
            }
            for (int i = n - 2; i > 0; i -= 2)
            {
                result += new string(' ', (n - i) / 2) + new string('*', i) + "\n";
            }
            return result;
        }

        /// <summary>
        /// Подсчитывает количество смайлов в исходном массиве
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <returns></returns>
        static int CountSmileys(string[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                switch(array[i])
                {
                    case ":)":
                        count += 1;
                        break;
                    case ":D":
                        count += 1;
                        break;
                    case ":-)":
                        count += 1;
                        break;
                    case ":~)":
                        count += 1;
                        break;
                    case ":-D":
                        count += 1;
                        break;
                    case ":~D":
                        count += 1;
                        break;
                    case ";)":
                        count += 1;
                        break;
                    case ";D":
                        count += 1;
                        break;
                    case ";-)":
                        count += 1;
                        break;
                    case ";~)":
                        count += 1;
                        break;
                    case ";-D":
                        count += 1;
                        break;
                    case ";~D":
                        count += 1;
                        break;
                }
            }
            return count;
        }

        // Задание 3
        public static void  FindValueClosestToZero(List<int> numbers)
        {
            int closest = numbers[0];
            int t = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (Math.Abs(numbers[i]) < Math.Abs(closest))
                {
                    closest = numbers[i];
                }
                else if (numbers[i] == 0 || closest == 0) 
                {
                    Console.WriteLine("Ближайшее к нулю число: 0");
                }
                else if (Math.Abs(numbers[i]) == Math.Abs(closest))
                {
                    Console.WriteLine("Ближайшее к нулю число: None");
                    t = 1;
                    break;
                }
            }
            if (t == 0)
            {
                Console.WriteLine($"Ближайшее к нулю число: {closest}");
            }
        }
        static void Main(string[] args)
        {
            int size = 5;
            string diamond = PrintDiamond(size);
            Console.WriteLine(diamond);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Задача 3\r\nЭто задание предназначено для проверки вашей способности расширять\r\nфункциональность встроенных классов. В этом случае мы хотим, чтобы вы расширили\r\nвстроенный класс Array следующими методами: Square(), Cube(), Average(), Sum(),\r\nEven() и Odd().\r\nОбъяснение:\r\n Square() должен возвращать копию массива, содержащую все значения,\r\nвозведенные в квадрат.\r\n Cube() должен возвращать копию массива, содержащую все значения,\r\nвозведенные в куб.\r\n Average() должен возвращать среднее значение всех значений массива; для\r\nпустого массива должен возвращать NaN.\r\n Sum() должен возвращать сумму всех значений массива\r\n Even() должен возвращать массив всех четных чисел\r\n Odd() должна возвращать массив всех нечетных чисел\r\nПримечание: исходный массив менять ни в коем случае нельзя!");
            int[] array = new int[5] { 2, 5, 12, 32, 0 };
            Console.WriteLine("Исходный массив:");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\nмассив, возведенный в квадрат: ");
            
            int[] squaredarray = array.Square();
            foreach (int i in squaredarray)
            {
                Console.Write(i + " ");
            }

            int[] cubedarray = array.Cube();
            Console.WriteLine("\n\nисходный массив, возведенный в куб: ");
            foreach (int i in cubedarray)
            {  
                Console.Write(i + " ");
            }

            double average = array.Average();
            Console.WriteLine($"\n\nСреднее значение исходного массива: {average}");

            int[] evenarray = array.Even();
            Console.WriteLine("\nмассив, состоящий из четных элементов исходного массива: ");
            foreach (int i in evenarray)
            { 
                Console.Write(i + " ");
            }

            int[] oddarray = array.Odd();
            Console.WriteLine("\n\nмассив, состоящий из нечетных элементов исходного массива: ");
            foreach (int i in oddarray)
            {  
                Console.Write(i + " "); 
            }
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Задача 4\r\nИспользуя массив (arr) в качестве аргумента, напишите функцию countSmileys, которая\r\nдолжна возвращать общее количество улыбающихся лиц.\r\nПравила улыбающегося лица:\r\n Каждый смайлик должен содержать действительную пару глаз.\r\n Глаза могут быть отмечены как : или ;\r\n У смайлика может быть нос, но это не обязательно.\r\n Допустимые символы для носа: - или ~.\r\n У каждого улыбающегося лица должен быть улыбающийся рот, отмеченный\r\nлибо ), либо D.\r\n Никакие дополнительные символы, кроме упомянутых, не допускаются.");
            Console.WriteLine("\n!Предполагаем, что смайлы, помимо прописанных обязательных условий, имеют порядок: глаза - нос (при его наличии) - рот");
            Console.WriteLine("\nИсходный массив со смайлами:");
            string[] smiles = { ":)", ";D", ":-)", ":~)", ";-D", "^0", ":D" };
            foreach (string s in smiles) 
            {  
                Console.Write(s + " "); 
            }
            Console.WriteLine("\nКоличество смайлов: " + CountSmileys(smiles));
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Задача 5\r\nПросто найдите ближайшее к нулю значение из списка. Обратите внимание, что в\r\nсписке есть минусы. Список всегда не пуст и содержит только целые числа.\r\nВозвращайте None, если невозможно определить только одно из таких значений. И,\r\nконечно же, мы ожидаем 0 как наиболее близкое к нулю значение.");
            List<int> list = new List<int>() { 2, 1, 4, 3, -5 };
            foreach (int i in list)
            {  
                Console.Write(i + " "); 
            }
            FindValueClosestToZero(list);
            Console.ReadLine();
        }
        
    }
}
