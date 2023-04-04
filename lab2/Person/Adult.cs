namespace Model
{
    /// <summary>
    /// Класс Adult.
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Минимальное значение серии паспорта.
        /// </summary>
        private const int _minPassportSeries = 0001;

        /// <summary>
        /// Максимальное значение серии паспорта.
        /// </summary>
        private const int _maxPassportSeries = 9999;

        /// <summary>
        /// Минимальное значение номера паспорта.
        /// </summary>
        private const int _minPassportNumber = 000001;

        /// <summary>
        /// Максимальное значение номера паспорта.
        /// </summary>
        private const int _maxPassportNumber = 999999;

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
        public const int MinAge = 18;

        /// <summary>
        /// Максимальный возраст.
        /// </summary>
        public const int MaxAge = 90;

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
                if (value != null && value.Gender == Gender)
                {
                    throw new ArgumentException
                        ($"Партнёр должен быть противоположного пола");
                }
                else
                {
                    _partner = value;
                }
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
                _passportSeries = CheckNumber(value, _minPassportSeries,
                    _maxPassportSeries);
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
                _passportNumber = CheckNumber(value, _minPassportNumber,
                    _maxPassportNumber);
            }
        }

        /// <summary>
        /// Свойство семейное положение.
        /// </summary>
        public MaritalStatus MaritalStatus { get; set; }

        /// <summary>
        /// Свойство место работы.
        /// </summary>
        public string Workplace { get; set; }

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
                _age = CheckNumber(value, MinAge, MaxAge);
            }
        }

        /// <summary>
        /// Метод представления данных.
        /// </summary>
        /// <returns>Данные персоны.</returns>
        public override string GetInfo()
        {
            string info = base.GetInfo();
            info += $"\nДанные паспорта: {PassportSeries} " +
                $"{PassportNumber}, " +
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

        /// <summary>
        /// Метод воспроизведения игры в русскую рулетку.
        /// </summary>
        /// <returns>Результат игры.</returns>
        public string PlayRussianRoulet()
        {
            Random random = new Random();

            var randomActcions = random.Next(6);
            var gameResult = randomActcions == 0
                ? "проигрыш"
                : "победа";

            return $"{Name} начинает игру в \"Русскую рулетку\". " +
                $"\nПатрон находится в каморе №1. \nВыстрел из каморы" +
                $" №{randomActcions + 1}. \nРезультат игры в русскую " +
                $"рулетку: {gameResult}.\n";
        }
    }
}
