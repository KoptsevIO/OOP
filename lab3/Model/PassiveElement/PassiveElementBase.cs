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
        /// Полное сопротивление.
        /// </summary>
        protected float _impedance;

        /// <summary>
        /// Свойство полное сопротивление.
        /// </summary>
        public abstract float Impedance { get; }

        /// <summary>
        /// Метод расчёта сопротивления.
        /// </summary>
        public abstract float CalculationImpedance();
    }
}
