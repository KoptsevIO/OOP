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
        /// Тип элемента.
        /// </summary>
        public override string ElementType
        {
            get
            {
                return $"Индуктивность";
            }
        }

        /// <summary>
        /// Параметры.
        /// </summary>
        public override string Parameter
        {
            get
            {
                return $"I = {Inductance} Гн";
            }
        }

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
        public override Complex Impedance
        {
            get
            {
                return new Complex(0, Inductance * _angularFrequency);
            }
        }
    }
}
