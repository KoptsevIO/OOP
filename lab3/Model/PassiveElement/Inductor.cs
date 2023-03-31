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
        /// Свойство ёмкость.
        /// </summary>
        public float Inductance { get; set; }

        /// <summary>
        /// Полное сопротивление.
        /// </summary>
        public override float Impedance
        {
            get
            {
                return (Inductance * Angularfrequency);
            }
        }

        /// <summary>
        /// Расчёт полного сопротивления.
        /// </summary>
        /// <returns>Impedance.</returns>
        public override float CalculationImpedance()
        {
            return Impedance;
        }
    }
}
