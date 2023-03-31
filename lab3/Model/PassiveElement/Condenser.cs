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
        public float Capacity { get; set; }

        /// <summary>
        /// Свойство сопротивление.
        /// </summary>
        public override float Impedance  
        {
            get
            {
                return - 1 / (Capacity * Angularfrequency);
            }
        }

        /// <summary>
        /// Метод расчёта сопротивления.
        /// </summary>
        /// <param name="impedance"></param>
        /// <returns>impedance.</returns>
        public override Complex CalculationImpedance(Complex impedance)
        {
            impedance = new Complex(0, Impedance);
            return impedance;
        }
    }
}
