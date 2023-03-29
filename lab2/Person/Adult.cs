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
        private int _passportSeries;

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
        /// Минимальный возраст.
        /// </summary>
        public const int Min = 18;

        /// <summary>
        /// Максимальный возраст.
        /// </summary>
        public const int Max = 90;

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
        public int PassportSeries
        {
            get
            {
                return _passportSeries;
            }

            set
            {
                _passportSeries = value;
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
        /// Свойство возраст.
        /// </summary>
        public override int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value > Max || value < Min)
                {
                    throw new ArgumentException($"Введён некорректный" +
                        $" возвраст Adult, введите возраст" +
                        $" от {Min} до {Max} лет!");
                }
                else
                {
                    _age = value;
                }
            }
        }

        /// <summary>
        /// Метод представления данных.
        /// </summary>
        /// <returns>Данные персоны.</returns>
        public override string GetInfo()
        {
            string info = base.GetInfo();
            info += $"\nДанные паспорта: {PassportSeries} {PassportNumber}, " +
                $"\nСемейное положение: {MaritalStatus}";

            if (MaritalStatus == MaritalStatus.Married)
            {
                info += $"\nПартнёр: {Partner.Name} " +
                    $"{Partner.Surname}, ";
            }

            info += "\nМесто работы: ";

            if (string.IsNullOrEmpty(Workplace))
            {
                info += "Безработный. ";
            }
            else
            {
                info += Workplace;
            }

            return info;
        }
    }
}
