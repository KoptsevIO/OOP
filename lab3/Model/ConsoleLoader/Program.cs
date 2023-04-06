namespace ConsoleLoader
{
    /// <summary>
    /// Класс Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Основная программа.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Программа расчёта сопротивления " +
                "пассивных элементов");

            while (true)
            {
                Console.Write("\nРасчитать комплексное сопротивление " +
                    "пассивных элементов - введите 1.\n" +
                    "Закончить выполнение программы - введите 2." +
                    "\nВвод: ");
                bool isParsed = short.TryParse(Console.ReadLine(),
                            out short numberAction);
                if (!isParsed)
                {
                    Console.WriteLine("Введите число 1 или 2!");
                }

                //TODO: switch-case
                if (numberAction == 1)
                {
                    AddPassiveElement.AddElement();
                }
                else if (numberAction == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Не распознана команда. \n" +
                        "Ведите заново.");
                }
            }
        }
    }
}