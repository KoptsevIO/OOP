namespace Model
{
    /// <summary>
    /// Класс Adult.
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Серия паспорта.
        /// </summary>
        private int _passportSerie;

        /// <summary>
        /// Номер паспорта.
        /// </summary>
        private int _passportNumber;

        /// <summary>
        /// Место работы.
        /// </summary>
        private string _workplace;

        /// <summary>
        /// Семейное положение.
        /// </summary>
        private MaritalStatus _maritalStatus;

        /// <summary>
        /// Супруг / супруга.
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Минимальный возраст Adult.
        /// </summary>
        public const int AdultMin = 18;

        /// <summary>
        /// Максимальный возраст Adult.
        /// </summary>
        public const int AdultMax = 90;

        /// <summary>
        /// Ссылка на супруга / супругу.
        /// </summary>
        public Adult Partner
        {
            get
            {
                return _partner;
            }

            set
            {
                _partner = value;
            }
        }

        /// <summary>
        /// Свойство серия паспорта.
        /// </summary>
        public int PassportSerie
        {
            get
            {
                return _passportSerie;
            }

            set
            {
                _passportSerie = value;
            }
        }

        /// <summary>
        /// Свойство номер паспорта.
        /// </summary>
        public int PassportNumber
        {
            get
            {
                return _passportNumber;
            }

            set
            {
                _passportNumber = value;
            }
        }

        /// <summary>
        /// Свойство семейное положение.
        /// </summary>
        public MaritalStatus MaritalStatus
        {
            get
            {
                return _maritalStatus;
            }

            set
            {
                _maritalStatus = value;
            }
        }

        /// <summary>
        /// Свойство место работы.
        /// </summary>
        public string Workplace
        {
            get
            {
                return _workplace;
            }

            set
            {
                _workplace = value;
            }
        }

        /// <summary>
        /// Свойство возраст Adult.
        /// </summary>
        public override int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value > AdultMax || value < AdultMin)
                {
                    throw new ArgumentException($"Введён некорректный" +
                        $" возвраст Adult, введите возраст" +
                        $" от {AdultMin} до {AdultMax} лет!");
                }
                else
                {
                    _age = value;
                }
            }
        }
    }
}
