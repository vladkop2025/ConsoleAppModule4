using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        { //Модуль 4. Основы C# и CLR. Основные конструкции C#
            /* 4.2. Циклы
               Цикл For определение и примеры применения - Цикл For - это цикл со счетчиком

           for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Iteration {0}", i);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }

            Другие примеры записи цикла For

                    for (double i = 0.0; i < 1.1; i += 0.01);
                    for (long i = 0; i < long.MaxValue; i++)

            Нам не обязательно задавать все части этого условия, например, мы можем инициализировать счётчик до самого цикла, 
            и просто опустить эту часть.

                int i = 1;
                for (; i < 5; i++) 
                {
                    Console.WriteLine("Iteration {0}", i);
                    switch (Console.ReadLine())
                }

            Также мы можем не указывать операцию, которая будет происходить после каждого шага. Можем указать её в так называемом 
            «теле цикла», то есть среди всех операций внутри фигурных скобок.

                 int i = 1;
                 for (; i < 5;)
                 {
                     Console.WriteLine("Iteration {0}", i);
                     switch (Console.ReadLine())

                             i++;
                 }

            как написать бесконечный цикл с помощью конструкции for?

                    for( ;;)

            Этот цикл может применяться, например, когда мы ждем некоторого ответа от пользователя и в этот момент выполняем какие-то 
            операции. Или же условие цикла невозможно определить в блоке условий цикла, мы можем его только прервать.

                    for (; ; )
                    {
                      switch (Console.ReadLine())
                    }

            зачем нам создавать какой-то счетчик, если у нас есть условие без конкретного количества итераций
            Давайте посмотрим на цикл с предусловием — while.

            Сделаем код бесконечного цикла с его помощью и посмотрим:

                    while (true)
                     {
                        switch (Console.ReadLine())
                     }

            Также давайте посмотрим на цикл с постусловием — do…while.
            Особенностью синтаксиса является то, что после условия while необходимо ставить символ окончания строки ; 

                    do
                    {
                        switch (Console.ReadLine())
                    }
                    while (true) ;

             три цикла со счётчиком через разные методы

                    for (int i = 0; i< 3; i++)
                    for (int i = 1; i< 4; i++)

            Предположите, что нужно сделать для цикла while?
                    Использовать инкремент в цикле, добавить переменную в условие, инициализировать переменную-счётчик

                     Console.WriteLine("Цикл while");
                     int k = 0;

                     while (k < 3)
                     {
                        Console.WriteLine(k);

                        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                        switch (Console.ReadLine())

                        k++;

                     }

            Так в чем же разница между циклами с постусловием и предусловием?

                    Console.WriteLine("Цикл while");
                     int k = 0;

                     while (k < 1)
                     {
                        Console.WriteLine(k);

                        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                        switch (Console.ReadLine())

                        k++;
                      }

                    do
                    {
                        Console.WriteLine(t);

                        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                         switch (Console.ReadLine())

                         t++;
                    } while (t < 1);

            результаты работы у этих циклов будут одинаковыми

            Какое значение нужно поставить переменным k и t в условие вместо 1, чтобы результат выполнения был разным?

               - 1

            Бесконечные циклы — очень неприятная вещь, при работе с настоящими задачами следует точно знать, что они нужны. 
            По отношению к ресурсами пользователя это не самая удачная практика.
            В рамках нашей тренировочной задачи неплохо было бы добавить некий момент распознавания сигнала пользователя. 
            Например, если мы введём слово "stop" вместо очередного цвета, программе бы хорошо прекратить нас о нём спрашивать.

                    int k = 0;

                 while (true)
                 {
                     Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                        Console.WriteLine(k);

                        var text = Console.ReadLine();

                    if (text == "stop")
                    {
                        Console.WriteLine("Цикл остановлен");
                         break;
                    }

                    switch (text)

                    k++;
                }

            оператор break показывает, где кончилась последовательность действий

            Так как break используется в операторе switch для прекращения его внутренних последовательностей (то есть вариантов
            «перебора» внутри оператора), мы не можем вызвать его для того, чтобы прекратить цикл, просто добавив дополнительный 
            case. Поэтому мы используем предварительную проверку: сначала смотрим, не ввел ли пользователь команду stop, а только потом переходим к дальнейшим действиям.
          
            Кроме оператора break, который позволяет прервать цикл, есть оператор continue.
            По сути, он позволяет ничего не делать, то есть никак не реагировать. 

            switch (text)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    continue;

            }
                        
            Мы указываем continue после варианта default в нашем условии. Это означает просто «иди дальше» в случае, 
            если введено любое значение, кроме "red", "green", "cyan".

            Рассмотрим работу цикла while на примере задачи для подсчета суммы положительных чисел. Пользователь может вводить числа, 
            программа должна будет считать сумму только тех из них, которые больше нуля. При получении 0 программа останавливается.

            int sum = 0;

            while (true)
            {
                Console.WriteLine("Введите число");
                var number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    continue;
                }
                else if (number == 0)
                {
                    break;
                }

                // number > 0
                sum += number;
            }

            Console.WriteLine("Итоговая сумма: {0}", sum);

            И последним по порядку, но не по важности, будет ещё один цикл с некоторым подобием счётчика — цикл foreach. 
            Это цикл «для каждого», и он используется в работе с некоторой последовательностью элементов. 

            Цикл foreach работает с сущностями, которые реализуют интерфейс IEnumerable. Детальные правила этого цикла 
            мы разберём с другом модуле. Пока для использования данного цикла вам будет достаточно иметь о нём общее представление

            */
        }
    }        
}
