using System;
using System.Numerics;

namespace PassiveElement
{
    /// <summary>
    /// Класс Resistor.
    /// </summary>
    public class Resistor : PassiveElementBase
    {
        /// <summary>
        /// Активное сопротивление.
        /// </summary>
        protected double _resistance;

        /// <summary>
        /// Свойство активное сопротивление.
        /// </summary>
        public double Resistance
        {
            get
            {
                return _resistance;
            }
            set
            {
                _resistance = CheckNumber(value);
            }
        }

        /// <summary>
        /// Свойство сопротивление.
        /// </summary>
        public override double Impedance => Math.Round(Resistance, 3);

        /// <summary>
        /// Метод расчёта сопротивления.
        /// </summary>
        /// <returns>impedance.</returns>
        public override Complex GetImpedance()
        {
            Complex impedance = new Complex(Impedance, 0);
            return impedance;
        }
    }
}
