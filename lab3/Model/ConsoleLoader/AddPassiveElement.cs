using PassiveElement;

namespace ConsoleLoader
{
    /// <summary>
    /// Класс AddPassiveElement.
    /// </summary>
    public class AddPassiveElement
    {
        /// <summary>
        /// Метод проверки ввода числа.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>checkNumber.</returns>
        /// <exception cref="ArgumentException">.</exception>
        private static float CheckNumber(string number)
        {
            if (number.Contains('.'))
            {
                number = number.Replace('.', ',');
            }

            bool isParsed = float.TryParse(number,
                        out float checkNumber);

            if (isParsed != true)
            {
                throw new ArgumentException("Введите число!");
            }

            return checkNumber;
        }
    }
}
