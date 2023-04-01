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
        protected float _resistance;

        /// <summary>
        /// Свойство активное сопротивление.
        /// </summary>
        public float Resistance
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
        public override float Impedance => Resistance;

        /// <summary>
        /// Метод расчёта сопротивления.
        /// </summary>
        /// <returns>impedance.</returns>
        public override Complex CalculationImpedance()
        {
            Complex impedance = new Complex(Impedance, 0);
            return impedance;
        }
    }
}
