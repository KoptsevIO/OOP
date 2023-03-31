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
        /// Полное сопротивление.
        /// </summary>
        public override float Impedance
        {
            get
            {
                return - 1 / (Capacity * Angularfrequency);
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
