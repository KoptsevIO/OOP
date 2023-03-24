using Model;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    /// <summary>
    /// Класс Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main program.
        /// </summary>
        public static void Main()
        {
            PersonList personlist1 = new PersonList();
            PersonList personlist2 = new PersonList();

            // п.3 (а)
            // Объявление персон и создание двух списков
            var person1 = new PersonBase("Dmitry", "Puchkov", Gender.Male, 61);
            var person2 = new PersonBase("Klim", "Zhukov", Gender.Male, 45);
            var person3 = new PersonBase("Mikhail", "Popov", Gender.Male, 78);
            var person4 = new PersonBase("Artemy", "Lebedev", Gender.Male, 48);
            var person5 = new PersonBase("Margarita", "Simonyan", Gender.Female,
                42);
            var person6 = new PersonBase("Dmitry", "Nazarov", Gender.Male, 65);

            // Создание списка 1
            personlist1.Add(person1);
            personlist1.Add(person2);
            personlist1.Add(person3);

            // Создание списка 2
            personlist2.Add(person4);
            personlist2.Add(person5);
            personlist2.Add(person6);

            // Вывод в консоль по нажатию  клавиатуры
            _ = Console.ReadKey();

            // п.3 (b)
            // Вывод списков в консоль
            Console.WriteLine("Список 1: ");
            PrintList(personlist1);

            Console.WriteLine("\nСписок 2: ");
            PrintList(personlist2);

            _ = Console.ReadKey();

            // п.3 (c)
            // Добавление нового человека в первый список
            Console.WriteLine("\nСоздание персоны с консоли: ");
            personlist1.Add(PersonConsole());

            Console.WriteLine("\nДополненный список 1: ");
            PrintList(personlist1);

            _ = Console.ReadKey();

            // п.3 (d)
            // Добавление в список 2 второго человека из списка1
            personlist2.Add(personlist1.PeopleFindByIndex(1));

            Console.WriteLine("\nСписок 1 после добавление нового " +
                "человека: ");
            PrintList(personlist1);

            Console.WriteLine("\nСписок 2 после копирования человека " +
                "из списка 1: ");
            PrintList(personlist2);

            _ = Console.ReadKey();

            // п.3 (е)
            // Удаление второго человека из первого списка.
            personlist1.PeopleRemoveAt(1);

            Console.WriteLine("\nСписок 1 после удаление человека: ");
            PrintList(personlist1);

            Console.WriteLine("\nСписок 2 после удаления человека " +
                "из списка 1: ");
            PrintList(personlist2);

            _ = Console.ReadKey();

            // п.3 (f)
            // Удаления второго списка
            personlist2.PeopleClear();

            Console.WriteLine("\nСписок 2 после отчистки: ");
            PrintList(personlist2);

        }

        /// <summary>
        /// Печать списка.
        /// </summary>
        /// <param name="personlist">Список.</param>
        private static void PrintList(PersonList personlist)
        {
            for (int item = 0; item < personlist.PeopleCount(); item++)
            {
                var person = personlist.PeopleFindByIndex(item);
                Console.WriteLine(person.PersonOutputConsole());
            }
        }

        /// <summary>
        /// Метод проверяет введёные пользовелелем слова.
        /// Можно вводить буквы и тире.
        /// </summary>
        /// <param name="word">Слово.</param>
        /// <returns>слово.</returns>
        /// <exception cref="ArgumentException">Слово.</exception>
        private static string CheckNames(string word)
        {
            Regex wordsAndHyphens = new Regex(@"^[A-z,А-я,-]+$");

            if (!wordsAndHyphens.IsMatch(word))
            {
                throw new ArgumentException("Не удалось распознать" +
                    " имя/фамилию, введите ещё раз!" +
                    "\n(разрешено вводить только буквы и дефис)");
            }
            else
            {
                return word;
            }
        }

        /// <summary>
        /// п. 4
        /// Метод чтения персоны с консоли.
        /// </summary>
        /// <returns>Персона.</returns>
        private static PersonBase PersonConsole()
        {
            PersonBase person = new PersonBase();

            var actionList = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите имя: ");
                    string name = CheckNames(Console.ReadLine());
                    person.Name = PersonBase.CheckNameSurname(name);
                }), "name"),
                (new Action(() =>
                {
                    Console.Write("Введите фамилию: ");
                    string surname = CheckNames(Console.ReadLine());
                    person.Surname = PersonBase.CheckNameSurname(surname);
                }), "surname"),
                (new Action(() =>
                {
                    Console.Write("Введите возраст: ");
                    bool result = ushort.TryParse(Console.ReadLine(),
                        out ushort age);
                    if(result != true)
                    {
                        throw new ArgumentException("Возраст введён" +
                            " не правильно, введите ещё раз!");
                    }

                    person.Age = age;
                }), "age"),
                (new Action(() =>
                {
                     Console.Write("Введите пол (первую букву гендера): ");

                    string gender = Console.ReadLine();

                    switch (gender)
                    {
                       case "m":
                       case "M":
                       case "м":
                       case "М":
                       {
                           person.Gender = Gender.Male;
                           break;
                       }

                       case "F":
                       case "f":
                       case "Ж":
                       case "ж":
                       {
                           person.Gender = Gender.Female;
                           break;
                       }

                       default:
                       {
                           throw new ArgumentException("Неверно введён пол");
                       }
                    }
                }), "gender")
            };

            foreach (var action in actionList)
            {
                ActionHandler(action.Item1, action.Item2);
            }

            return person;

        }

        /// <summary>
        /// Получение значений введеных ползователем.
        /// Задание параметров.
        /// </summary>
        /// <param name="action">Action.</param>
        /// <param name="propertyName">propertyName.</param>
        private static void ActionHandler(Action action, string propertyName)
        {

            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception exception)
                {
                    if (exception.GetType() == typeof(ArgumentException)
                        || exception.GetType() == typeof(FormatException))
                    {
                        Console.WriteLine($"Incorrect {propertyName}. " +
                            $"Error: {exception.Message}");
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }
        }

    }
}
