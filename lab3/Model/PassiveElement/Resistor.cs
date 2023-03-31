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
        /// Полное сопротивление.
        /// </summary>
        public override float Impedance
        {
            get
            {
                return Resistance;
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
