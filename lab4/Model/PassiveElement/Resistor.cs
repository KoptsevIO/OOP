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
        /// Тип элемента.
        /// </summary>
        public override string ElementType
        {
            get
            {
                return $"Резистор";
            }
        }

        /// <summary>
        /// Параметры.
        /// </summary>
        public override string Parameter
        {
            get
            {
                return $"R = {Resistance}";
            }
        }

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
