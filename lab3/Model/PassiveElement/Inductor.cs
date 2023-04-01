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
        protected float _inductance;

        /// <summary>
        /// Свойство индуктивность.
        /// </summary>
        public float Inductance { get; set; }

        /// <summary>
        /// Свойство сопротивление.
        /// </summary>
        public override float Impedance
        {
            get
            {
                return (Inductance * Angularfrequency);
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
