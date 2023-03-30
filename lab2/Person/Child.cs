namespace Model
{
    /// <summary>
    /// Класс Child.
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Отец.
        /// </summary>
        private Adult _dad;

        /// <summary>
        /// Мать.
        /// </summary>
        private Adult _mom;

        /// <summary>
        /// Место учёбы.
        /// </summary>
        private string _educationLevel;

        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        public const int MinAge = 1;

        /// <summary>
        /// Максимальный возраст.
        /// </summary>
        public const int MaxAge = 17;

        /// <summary>
        /// Информация об отце.
        /// </summary>
        public Adult Dad { get; set; }

        /// <summary>
        /// Информация об отце.
        /// </summary>
        public Adult Mom { get; set; }

        /// <summary>
        /// Место учёбы.
        /// </summary>
        public string EducationLevel { get; set; }

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
                if (value > MaxAge || value < MinAge)
                {
                    throw new ArgumentException($"Введён некорректный" +
                        $" возвраст Child, введите возраст" +
                        $" от {MinAge} до {MaxAge} лет!");
                }
                else
                {
                    _age = value;
                }
            }
        }

        /// <summary>
        /// Метод проверки наличия родителя.
        /// </summary>
        /// <param name="perent">Родитель.</param>
        /// <param name="name">Имя.</param>
        /// <returns>Имя.</returns>
        private static string CheckParents(Adult perent, string name)
        {
            if (perent != null)
            {
                return $"\nДанные {name}: {perent.Name} " +
                    $"{perent.Surname}, ";
            }
            else
            {
                return $"\nИмя {name} не установлено, ";
            }
        }

        /// <summary>
        /// Метод представления данных.
        /// </summary>
        /// <returns>Информацию о персоне.</returns>
        public override string GetInfo()
        {
            string info = base.GetInfo();

            info += CheckParents(Mom, "матери");
            info += CheckParents(Dad, "отца");

            info += "\nМесто учёбы: ";
            if (string.IsNullOrEmpty(EducationLevel))
            {
                info += "Ребёнок не учится ни в детском саду, " +
                    "ни в школе.";
            }
            else
            {
                info += EducationLevel;
            }

            return info;
        }

        /// <summary>
        /// Метод определения любимого мультфильма.
        /// </summary>
        /// <returns>Название любимого мультфильма.</returns>
        public static string GetFavoriteCartoon()
        {
            string[] cartoons = { "Том и Джерри", "Атлантида", "Аркадий " +
                    "паровозов", "Шрек", "Тайна третьей планеты", "Мулан"};

            var randomCartoons = cartoons
                [new Random().Next(cartoons.Length)];

            return $"Название любимого мультфильма ребёнка: " +
                $"{randomCartoons}";
        }
    }
}
