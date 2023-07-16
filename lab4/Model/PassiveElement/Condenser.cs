using System;
using System.Numerics;

namespace PassiveElement
{
    /// <summary>
    /// Класс Condenser.
    /// </summary>
    public class Condenser : PassiveElementBase
    {
        /// <summary>
        /// Ёмкость.
        /// </summary>
        protected double _capacity;

        /// <summary>
        /// Тип элемента.
        /// </summary>
        public override string ElementType
        {
            get
            {
                return $"Конденсатор";
            }
        }

        /// <summary>
        /// Параметры.
        /// </summary>
        public override string Parameter
        {
            get
            {
                return $"С = {Capacity} Ф";
            }
        }

        /// <summary>
        /// Свойство ёмкость.
        /// </summary>
        public double Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = CheckNumber(value);
            }
        }

        /// <summary>
        /// Свойство сопротивление.
        /// </summary>
        public override Complex Impedance  
        {
            get
            {
                return new Complex(0, -1 / (Capacity *
                    _angularFrequency));
            }
        }
    }
}
