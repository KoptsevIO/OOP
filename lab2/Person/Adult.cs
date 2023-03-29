namespace Model
{
    /// <summary>
    /// Класс Adult.
    /// </summary>
    public class Adult : PersonBase
    {
        //TODO:
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
        /// Минимальный возраст.
        /// </summary>
        public const int Min = 18;

        /// <summary>
        /// Максимальный возраст.
        /// </summary>
        public const int Max = 90;

        //TODO: auto properties
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

        //TODO: check
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

        //TODO: check
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

        //TODO: rename
        /// <summary>
        /// Метод представления.
        /// </summary>
        /// <returns>Информация о персоне.</returns>
        public override string PersonOutputConsole()
        {
            string info = base.PersonOutputConsole();
            info += $"\nДанные паспорта: {PassportSerie} {PassportNumber}, " +
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
