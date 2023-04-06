using System;
using System.Numerics;

namespace PassiveElement
{
    /// <summary>
    /// Класс PassiveElementBase.
    /// </summary>
    public abstract class PassiveElementBase
    {
        /// <summary>
        /// Угловая частота электрического тока.
        /// </summary>
        protected const int _angularFrequency = 314;

        /// <summary>
        /// Сопротивление.
        /// </summary>
        protected double _impedance;

        /// <summary>
        /// Свойство сопротивление.
        /// </summary>
        public abstract double Impedance { get; }

        /// <summary>
        /// Метод расчёта сопротивления.
        /// </summary>
        public abstract Complex GetImpedance();

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
