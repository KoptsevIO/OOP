using System;
using System.Numerics;

namespace PassiveElement
{
    /// <summary>
    /// Класс PassiveElementBase.
    /// </summary>
    public abstract class PassiveElementBase
    {
        //TODO: +
        /// <summary>
        /// Угловая частота электрического тока.
        /// </summary>
        protected const double _angularFrequency = 100 * Math.PI;

        /// <summary>
        /// Сопротивление.
        /// </summary>
        protected double _impedance;

        /// <summary>
        /// Метод расчёта полного сопротивления.
        /// </summary>
        public abstract Complex Impedance { get; }

        /// <summary>
        /// Метод проверки введённого числа.
        /// </summary>
        /// <param name="number">number.</param>
        /// <returns>number.</returns>
        /// <exception cref="ArgumentException">ArgumentException.
        /// </exception>
        protected static double CheckNumber(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("число должно быть" +
                    " положительным.");
            }
            else
            {
                return number;
            }
        }
    }
}
