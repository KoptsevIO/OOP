using Model;

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

            // Заполнение списка рандомными персонами.
            for (int i = 0; i < 7; i++)
            {
                personlist1.Add(RandomPerson.GetAdultOrChild());
            }

            // Вывод списка в консоль
            Console.WriteLine("Список персон: ");
            PrintList(personlist1);

            _ = Console.ReadLine();

            // Определение типа четвёртого элмента списка personlist1
            // и примение методов, присущих этому классу
            switch (personlist1.PeopleFindByIndex(3))
            {
                case Adult adult:
                    {
                        Console.WriteLine("Это Adult");
                        Console.Write(adult.PlayRussianRoulet());
                        break;
                    }

                case Child child:
                    {
                        Console.WriteLine("Это Child");
                        Console.Write(child.GetFavoriteCartoon());
                        break;
                    }

                default:
                    break;
            }
        }

        /// <summary>
        /// Печать списка.
        /// </summary>
        /// <param name="personlist">Список.</param>
        private static void PrintList(PersonList personlist)
        {
            for (int item = 0; item < personlist.PeopleCount(); item++)
            {
                Console.WriteLine($"\nПерсона № {item + 1}");

                var person = personlist.PeopleFindByIndex(item);
                Console.WriteLine(person.GetInfo());
            }
        }
    }
}
