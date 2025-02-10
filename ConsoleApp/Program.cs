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
            /* 4.5.Практикум
             Необходимо разработать методику анкетирования пользователей. Требуется сохранять информацию: об имени пользователя, 
            фамилии, логине, длине логина, наличии/отсутствии у пользователя питомца, возрасте пользователя, трех любимых цветах 
            пользователя.

                (string name, string lastname, string login, int loginlength, bool haspet, string[] favcolor, double age) User;

            Заполните кортеж User значениями с клавиатуры для полей: имя пользователя, фамилия, логин.

                Console.WriteLine("Введите имя");
                User.name = Console.Readline();

                Console.WriteLine("Введите фамилию");
                User.lastname = Console.Readline();

                Console.WriteLine("Введите логин");
                User.login = Console.Readline();

                User.loginlength = User.login.Length;
                
            Напишите условие, которое устанавливает значение ИСТИНА в поле наличие/отсутствие животных, если пользователь 
            вводит "Да", и ЛОЖЬ при любом другом варианте.

                Console.WriteLine("Введите возраст пользователя");
                User.nage = Double.Parse.(Console.Readline());

                For(int i = 0; i < User.favcolor; i++)
                {
                    User.favcolor[i] = Console.Readline();
                }

            Сделайте так, чтобы опрос повторялся для трех пользователей.
            Не требуются модификации кода, требуется только добавить цикл.

                For(int k; k <3; k++)
                {
                    ...
                };

            */

            //Итоговый код программы
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            for (int k = 0; k < 3; k++)
            {

                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");

                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");

                var result = Console.ReadLine();

                if (result == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.WriteLine("Введите возраст пользователя");

                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
            }
        }
    }
}
