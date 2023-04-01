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
        protected float _capacity;

        /// <summary>
        /// Свойство ёмкость.
        /// </summary>
        public float Capacity
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
        public override float Impedance  
        {
            get
            {
                return - 1000000 / (Capacity * Angularfrequency);
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
