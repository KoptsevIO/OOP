using System;
using System.Numerics;

namespace PassiveElement
{
    /// <summary>
    /// Класс Inductor.
    /// </summary>
    public class Inductor : PassiveElementBase
    {
        /// <summary>
        /// Индуктивность.
        /// </summary>
        protected double _inductance;

        /// <summary>
        /// Свойство индуктивность.
        /// </summary>
        public double Inductance
        {
            get
            {
                return _inductance;
            }
            set
            {
                _inductance = CheckNumber(value);
            }
        }

        /// <summary>
        /// Свойство сопротивление.
        /// </summary>
        public override double Impedance
        {
            get
            {
                return Math.Round(Inductance * Angularfrequency / 1000, 3);
            }
        }

        /// <summary>
        /// Метод расчёта сопротивления.
        /// </summary>
        /// <returns>impedance.</returns>
        public override Complex CalculationImpedance()
        {
            Complex impedance = new Complex(0, Impedance);
            return impedance;
        }
    }
}
