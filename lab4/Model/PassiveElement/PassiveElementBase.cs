using System;
using System.ComponentModel;
using System.Numerics;
using System.Xml.Serialization;

namespace PassiveElement
{
    /// <summary>
    /// Класс PassiveElementBase.
    /// </summary>
    [XmlInclude(typeof(Condenser))]
    [XmlInclude(typeof(Inductor))]
    [XmlInclude(typeof(Resistor))]
    public abstract class PassiveElementBase
    {
        /// <summary>
        /// Угловая частота электрического тока.
        /// </summary>
        protected const double _angularFrequency = 100 * Math.PI;

        /// <summary>
        /// Сопротивление.
        /// </summary>
        protected double _impedance;

        /// <summary>
        /// Тип элемента.
        /// </summary>
        [DisplayName("Тип элемента")]
        public abstract string ElementType { get; }

        /// <summary>
        /// Метод возвращения параметра элемента.
        /// </summary>
        [DisplayName("Параметр")]
        public virtual string Parameter { get; }

        /// <summary>
        /// Метод расчёта полного сопротивления.
        /// </summary>
        [DisplayName("Полное сопротивление, Ом")]
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
