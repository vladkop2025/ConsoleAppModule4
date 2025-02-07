using System;
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
            /* 
                *********************************************************
                4.1.Условные выражения и конструкци
                *********************************************************
                Литерал — это неизменяемое значение, у которого нет какого-либо имени или обозначения (см. урок 3.2. Переменные, константы, литералы)
                    Строковым литералом является некое значение в двойных кавычках
                    Cимвольные литералы обозначаются в одинарных кавычках
                               Чаще всего используются символьные литералы для обозначения символов таблицы Unicode или же ASII 
                    Логические литералы - true и false (1 и 0)
                    Литералами являются цифры, которые мы можем ввести с клавиатуры - их можно присвоить какой-либо переменной, а можно просто отобразить
                              Цифры можно записывать в другой системе счисления — двоичной и шестнадцатеричной— и использовать вещественные цифры (это цифры типа 8.9, 54.87 и т.п. )
                    Отдельно от всех стоит литерал null — он представляет ссылку, которая не указывает ни на какой объект

                Операторы и операции ниже используются для работы с логическими значениями (true и false) и часто применяются в условиях и циклах
                -----------------------------
                Операторы сравнения
                -----------------------------
                    == 	Равенство	 
                    != 	Неравенство
                    <  	Меньше чем	  
                    >  	Больше чем
                    <= 	Меньше или равно	 
                    >= 	Больше или равно 
                -----------------------------
                Логические операции
                -----------------------------
                    Логическое  И (AND)   - &&	Возвращает true, если оба операнда истинны.
                    Логическое  ИЛИ (OR)  - ||	Возвращает true, если хотя бы один из операндов истинен.
                    Логическое  НЕ (NOT)  - !	Инвертирует значение операнда: если операнд true, возвращает false, и наоборот.
                    Условное    И (AND)   - &	Выполняет логическое И, но всегда вычисляет оба операнда, даже если первый false.
                    Условное    ИЛИ (OR)  - |	Выполняет логическое ИЛИ, но всегда вычисляет оба операнда, даже если первый true.
                    Исключающее ИЛИ (XOR) - ^	Возвращает true, если только один из операндов истинен, но не оба.
                bool - логический тип данных.
                */

            /* Примеры с решением
                var myapples = 5;
	            var hisapples = 6;
	            var hispeares = 5;
                var result = (myapples != hispeares) & (myapples < hisapples);
                Console.WriteLine(result);
	            Console.ReadKey();
            Запишите код, который проверяет следующее выражение: переменная A типа string не равна переменной B типа string.
                string A = "12";
                string B = "14";
                bool C = A != B;
            Запишите код, который проверяет следующее выражение: переменная A типа int меньше переменной B типа int, или переменная X типа double больше переменной Y типа double
                int a = 3;
                int b = 5;
                double x = 55.0;
                double y = 34.0;
                bool c = (a < b) | (x > y);
            В окне снизу введите результат выполнения программы - будет False
                var inv = true;
		        var result = !inv;
                Console.WriteLine(result);
                -----------------------------
                Условная конструкция
                -----------------------------
                    IF (условие) {действие} ELSE {другое действие} - Блок else можно опускать, он не всегда требуется.
               -----------------------------
               Для повышения удобства сделана тернарная операция или тернарный оператор - это сокращенная форма записи условного выражения
               результат = условие ? значение_если_истина : значение_если_ложь;
                    условие — выражение, которое возвращает true или false.
                    значение_если_истина — значение, которое возвращается, если условие истинно.
                    значение_если_ложь — значение, которое возвращается, если условие ложно.
               -----------------------------
                   var a = 6;
		           var b = 7;
                   var c = a != b ? a + b : b;
                   Console.WriteLine(c);        //выведет 13
         */

            //Console.BackgroundColor — свойство цвета фона консоли (не всего, а того, который у наших данных).
            //Console.ForegroundColor — свойство цвета шрифта

            /*
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Consol e.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
             */


            /* Для подобных задач есть ещё одна подходящая условная конструкция: switch («переключатель»)
               В скобках оператора switch указывается переменная (или условие), которое проверяется, некое сравнимое выражение. 
               В нём могут быть переменные. Или же какие-то операции.
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                Например, вот так тоже будет работать:
                switch (Console.ReadLine()) 
                {
                ...
            Блок default — это если значение не соответствует ни одному из условий. Он является правилом хорошего тона, но его можно опустить.

            var color = Console.ReadLine();

            switch (color)
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

                default:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

            Оператор break показывает, где кончилась последовательность действий для заданного условия. Он обязателен, 
            но можно также использовать вместо него другие операторы перехода: goto case, return или throw.
            */

            //Добавьте в программу обработку ввода цвета cyan, а в блоке default поменяйте на желтый цвет цвет фона, а цвет текста — на красный.
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
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
        }
    }
}
