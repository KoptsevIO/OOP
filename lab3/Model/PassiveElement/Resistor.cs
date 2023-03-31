using System.ComponentModel;
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
        public float Resistance { get; set; }

        /// <summary>
        /// Свойство сопротивление.
        /// </summary>
        public override float Impedance => Resistance;

        /// <summary>
        /// Метод расчёта сопротивления.
        /// </summary>
        /// <param name="impedance"></param>
        /// <returns>impedance.</returns>
        public override Complex CalculationImpedance(Complex impedance)
        {
            impedance = new Complex(Impedance, 0);
            return impedance;
        }
    }
}
