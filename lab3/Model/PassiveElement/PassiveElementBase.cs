using System.Numerics;

namespace PassiveElement
{
    /// <summary>
    /// Класс ImpedanceBase.
    /// </summary>
    public abstract class PassiveElementBase
    {
        /// <summary>
        /// Угловая частота электрического тока.
        /// </summary>
        protected const int Angularfrequency = 314;

        /// <summary>
        /// Сопротивление.
        /// </summary>
        protected float _impedance;

        /// <summary>
        /// Свойство сопротивление.
        /// </summary>
        public abstract float Impedance { get; }

        /// <summary>
        /// Метод расчёта сопротивления.
        /// </summary>
        /// <returns>impedance.</returns>
        public abstract Complex CalculationImpedance(Complex impedance);
    }
}
