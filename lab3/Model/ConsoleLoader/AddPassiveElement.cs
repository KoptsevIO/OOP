using PassiveElement;
using System.Numerics;

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
        private static double CheckNumber(string number)
        {
            if (number.Contains('.'))
            {
                number = number.Replace('.', ',');
            }

            bool isParsed = double.TryParse(number,
                        out double checkNumber);

            if (!isParsed)
            {
                throw new ArgumentException("введите число!");
            }

            return checkNumber;
        }

        /// <summary>
        /// Метод добавления параметров пассивных элементов.
        /// </summary>
        /// <exception cref="ArgumentException">ArgumentException.
        /// </exception>
        public static void AddElement()
        {
            PassiveElementBase element = new Resistor();

            Action actionStart = new Action(() =>
            {
                Console.Write($"1 - резистор,\n" +
                    $"2 - конденсатор,\n3 - катушка индуктивности." +
                    $"\nВыберете пассивный элемент: ");

                bool isParsed = int.TryParse(Console.ReadLine(), 
                    out int what);

                switch (what)
                {
                    case 1:
                        {
                            element = new Resistor();
                            break;
                        }

                    case 2:
                        {
                            element = new Condenser();
                            break;
                        }
                    case 3:
                        {
                            element = new Inductor();
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException("Введите " +
                                "корректно.");
                            break;
                        }
                }
            });

            var actionResistor = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите сопротивление резистора, Ом: ");
                    Resistor resistor = (Resistor)element;

                    resistor.Resistance = CheckNumber(Console.ReadLine());

                }), "резистора"),
                (new Action(() =>
                {
                    Resistor resistor = (Resistor)element;
                    Console.WriteLine("Комплексное сопротивление " +
                        "резистора, Ом: " + resistor.GetImpedance()
                        + "\n");
                    _ = Console.ReadKey();
                }), "резистора")
            };

            var actionCondenser = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Condenser condenser = (Condenser)element;
                    Console.Write("Введите ёмкость конденсатора, мкФ: ");

                    condenser.Capacity = CheckNumber(Console.ReadLine());

                }), "конденсатора"),
                (new Action(() =>
                {
                    Console.WriteLine($"Комплексное сопротивление " +
                        $"конденсатора, Ом: " +
                        $"{element.GetImpedance()}" + "\n");
                    _ = Console.ReadKey();

                }), "конденсатора")
            };

            var actionInductor = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Inductor inductor = (Inductor)element;
                    Console.Write("Введите индуктивность катушки" +
                        " индуктивности, мГн: ");

                    inductor.Inductance = CheckNumber(Console.ReadLine());

                }), "катушки индуктивности"),
                (new Action(() =>
                {
                    Console.WriteLine($"Комплексное сопротивление" +
                        $"катушки индуктивности, Ом: " +
                        $"{element.GetImpedance()}" + "\n");
                    _ = Console.ReadKey();

                }), "катушки индуктивности")
            };

            // Выбор пассивного элемента
            ActionHandler(actionStart, "в пассивный элемент");

            var passiveElementActionDictionary = new Dictionary<Type, 
                List<(Action, string)>>
            {
                {typeof(Resistor), actionResistor},
                {typeof(Condenser), actionCondenser},
                {typeof(Inductor), actionInductor},
            };

            foreach (var action in passiveElementActionDictionary
                [element.GetType()])
            {
                ActionHandler(action.Item1, action.Item2);
            }
        }

        /// <summary>
        /// Метод использования Action.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="propertyName">propertyName.</param>
        private static void ActionHandler(Action action, string 
            propertyName)
        {

            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (ArgumentException exception)
                {

                    Console.WriteLine($"Некоректный ввод параметров " +
                        $"{propertyName}. Ошибка: {exception.Message}");

                }
            }
        }
    }
}
