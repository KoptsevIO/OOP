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
        public override Complex Impedance => Resistance;
    }
}
