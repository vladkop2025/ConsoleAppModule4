﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        { //Модуль 4. Основы C# и CLR. Основные конструкции C#
            /*   4.3.Массивы
                Пример программы
                string[] favcolors = new string[3];

                for(int i = 0; i < favcolors.Length; i++)
                {
                    Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
                    favcolors[i] = Console.ReadLine();
                }

                foreach(var color in favcolors)
                {
                switch (color)
                } 

            мы можем сделать то же самое, просто создав три переменных с разными названиями, 
            и последовательно вносить в них значения с клавиатуры, а если их 100?
            Массив — это некоторый набор однотипных данных. Проще говоря, его можно представить 
            как множество «переменных», в которые мы передаем разные значения.

            string[] favcolors = new string[3]; /массив объявляется и инициализируется этой строкой
            переменная favcolors — переменная типа массива строк
            Ключевое слово new мы рассмотрим в модулях позднее. Сейчас стоит запомнить его использование: 
            оно требуется нам, когда мы хотим что-то создать. Его мы будем использовать каждый раз, когда 
            требуется что-то новое, например, создать новый массив. 
            Далее мы используем уже знакомый нам синтаксис из объявления типа переменной, так мы указываем, 
            что именно хотим создать. А в квадратных скобках мы указываем размерность массива.

            Размерность также можно назвать длиной массива. Обратиться к ней можно с помощью свойства 
            length — оно вернёт количество элементов массива.

            //Размерность массива 
                var arr = new int[] { 1,2,3,4 };
                var l = arr.Length;

            //Разные виды инициализации массива
                int[] arr1 = new int[4] { 1,2,3,5};
                int[] arr2 = new int[] { 1,2,3,5};
                int[] arr3 = new[] { 1,2,3,5};
                int[] arr4 = { 1,2,3,5};

            Все эти варианты равнозначны, если мы задаем массив сами изначально. Если же мы не задаём его значения, 
            то мы должны указать размерность массива обязательно.

            Индекс — это порядковый номер элемента в массиве - нужен для того чтобы обратиться к элементу массив
            Важно! Нумерация элементов в массиве начинается с 0, то есть, первый элемент будет на “нулевой” позиции.
                favcolors[i] = Console.ReadLine();
            */

            var numbers = new int[] { 6, 30, 7, 14, 2, 15 };
                int minValue = 100000,
                minIndex = -1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < minValue)
                    {
                        minValue = numbers[i];
                        minIndex = i;
                    }
                }

                Console.WriteLine("Наименьший элемент массива имеет индекс {0}, значение этого элемента = {1}", minIndex, numbers[minIndex]);

                Console.ReadKey();

                /*Ответ Наименьший элемент массива имеет индекс 4, значение этого элемента = 2
                  В отличие от перечислений enum, индексацию массива нельзя изменить, нужно только запомнить 

                 Следующий блок кода — цикл, который упоминался в конце прошлого юнита — цикл foreach.
                 Этот цикл представляет собой перебор всех элементов массива: по сути, вместо того, чтобы 
                 обращаться по счётчику, мы просто применяем этот цикл для работы с конкретными элементами.

                    foreach (var color in favcolors) 
                     switch(color)
                    }

                 В скобках мы указываем переменную, в которую будет «помещаться» текущий по порядку элемент массива. 
                После служебного слова in указывается массив или другая последовательность. Использование данного цикла 
                для чего-то ещё мы разберем в других модулях, сейчас сосредоточимся на массивах.
                Для переменной необходимо указать тип, и он должен совпадать с типом массива. Или же, что гораздо удобнее, 
                использовать служебное слово var. Тогда нам не потребуется указывать конкретный тип данных.

                Строки являются массивами из символов. Любое слово в этом модуле — само по себе массив. Мы можем обратиться
                к каждой его букве по порядку.

                    Console.WriteLine("Введите своё имя");
                    var name = Console.ReadLine();
                    Console.WriteLine("Ваше имя по буквам: ");
                    foreach(var ch in name)		            {
                        Console.Write(ch + " ");
                    }
                    Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);
                    Console.ReadKey();

                Программа, которая переставляет буквы вашего имени в обратном порядке
                Необходимо использовать цикл for, индексы и значение длины массива.

                    string name;
                    Console.WriteLine("Введите своё имя");
                    name = Console.ReadLine(); // Считываем имя пользователя
                    // Выводим символы имени в обратном порядке
                    for (int i = name.Length - 1; i >= 0; i--)
                    {
                     Console.WriteLine(name[i] + " ");
                    }

                У массива есть такая характеристика, как ранг: для одномерного он равен 1, для двумерного 2, 
                для трёхмерного 3… и так далее. Как же задать массив с рангом больше 1? 

                    int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } }; //Этот массив будет представлять собой таблицу
                Пример
                    int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
                    Console.WriteLine(array[0, 0]);               //выведет 1
                Пример
                    int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
                    foreach (var item in array)
                         {
                            Console.Write(item + " ");  //выведет 1 2 3 5 6 7
                         }
                Пример
                    int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
                    Console.WriteLine(array.Length);   //выведет 6
                Нам необходимо выяснить, как вычислить индекс каждого элемента, и длина массива тут нам не поможет
                Для решения этой задачи у массива есть специальное средство: GetUpperBound. 
                    Console.WriteLine(array.GetUpperBound(0));  

                В скобках необходимо указать размерность массива, для которого нам нужно посчитать это значение.
                    Console.Write("Количество строк: ");
                    Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

                    Console.Write("Количество колонок: ");
                    Console.WriteLine(array.GetUpperBound(1) + 1 + " ")

                Зная ограничения, мы можем «вложить» два цикла по перебору массива друг в друга

                 */

                //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
                int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };
                for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
                {
                    for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                        Console.Write(array[i, k] + " ");

                    Console.WriteLine();
                    /*1 2 3  Ответ
                      5 6 7
                      8 9 10
                      11 12 13
                    */
                }

                //программа, которая отображает этот же массив, но только перебор начинается по столбцам
                for (int j = 0; j < array.GetUpperBound(0) + 1; j++)
                {
                    for (int l = 0; l < array.GetUpperBound(1) + 1; l++)
                        Console.Write(array[j, l] + " ");

                    Console.WriteLine();
                    /*1 2 3  Ответ
                      5 6 7
                      8 9 10
                      11 12 13
                    */

                    //  Методы подобного перебора равнозначны, количество проходов по массиву будет одинаковым.
                    //  Это вопрос во многом удобства конкретного программиста и поставленной задачи. 
                }

                //необходимо отсортировать массив в порядке возрастания цифр и вывести на экран
                var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

                //один из вариантов
                /*
                        int temp;

                     for (int i = 0; i < arr.Length; i++)
                     {
                            for (int j = i + 1; j < arr.Length; j++)
                         {
                              if (arr[i] > arr[j])
                             {
                                  temp = arr[i];
                                 arr[i] = arr[j];
                                 arr[j] = temp;
                                }
                         }
                            foreach (var item in arr)
                         {
                                Console.Write(item);
                            }
                        }
                */

                //Необходимо найти сумму всех элементов массива  var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
                /*
                    int sum = 0;
                     for (int i = 0; i < arr.Length; m++)
                        {
                            sum += arr[i];
                         }
                        Console.WriteLine(sum);
                */

                /*Сейчас мы рассмотрели многомерные массивы.Но это не весь функционал, который можно использовать.
                  Мы также можем сделать массив массивов
                    int[][] array = new int[3][]; //размерность указывается только в первых квадратных скобках, остальные должны быть пустыми
                    //массив массивовдля цифр типа int
                    array[0] = new int[2] { 1, 2 };
                    array[1] = new int[3] { 1, 2, 3 };
                    array[2] = new int[5] { 1, 2, 3, 4, 5 };
                */

                /* перебор данного массива массивов по аналогии с массивом строк
                    int[][] array = new int[3][];

                     array[0] = new int[2] { 1, 2 };
                        array[1] = new int[3] { 1, 2, 3 };
                        array[2] = new int[5] { 1, 2, 3, 4, 5 };

                        foreach (var num in array1)
                     {
                         foreach (var item in num)
                         {
                              Console.Write(item + " ");
                         }
                     }
                */

                /*Задайте одномерный массив и напишите алгоритм, который находит в нем количество положительных
                        var array = new int[] { -1, 2, 3, -5, 6, 7, 8, 9, -8, 11, 0, -13 };
                        var numbers = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] > 0)
                             numbers++;
                        }
                         Console.WriteLine(numbers);
                 Массивы и варианты их расширения, коллекции, которые мы рассмотрим позднее, являются одним из основных 
                 инструментов программиста.
                */

                /* Необходимо найти количество положительных элементов массива
                 с использованием  foreach:
                        var array = new int[,] { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
                        int temp = 0;
                        foreach(var item in array)
                         {
                             if (item > 0)
                                temp++;
                        }
                с использованием  for:
                        var array = new int[,] { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
                        int temp = 0;
                        for ( int i = 0, int <= array.GetUpperBound(0), i++ )
                        {
                            for ( int j = 0, int <= array.GetUpperBound(1), j++ )
                                if (array[i,j] > 0)
                                     temp++;
                        }   
                */

                /* Одной из нетривиальных задач является задача сортировки двумерного массива
                   реализуем просто сортировку элементов массива внутри одной строки 
                   Необходимо использовать три цикла: один для прохода по строкам, другие два для сортировки 
                        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
                        int temp = 0;
                        for (int i = 0; i < arr.GetUpperBound(0); i++)
                        {
                            for (int j = 0; j < arr.GetUpperBound(1); j++)
                             for (int k = 0; k < arr.GetUpperBound(1); k++)
                                 if (arr[i,j] < arr[i,k])
                             {   
                                 temp = arr[i, k];
                                 arr[i, k] = arr[i, j];
                                 arr[i, j] = temp;
                             }
                        }
                   В следующем юните вы узнаете, что такое кортежи и в чем их отличие от массивов
                 */
        }
    }
}