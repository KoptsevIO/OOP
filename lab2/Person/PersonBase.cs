using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Класс персон.
    /// </summary>
    public abstract class PersonBase
    {
        /// <summary>
        /// Имя.
        /// </summary>
        protected string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        protected string _surname;

        /// <summary>
        /// Пол.
        /// </summary>
        protected Gender _gender;

        /// <summary>
        /// Возраст.
        /// </summary>
        protected int _age;

        /// <summary>
        /// Имя персоны.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = ConvertToRightRegister(value);
                if (_surname != null)
                {
                    CheckLanguage(_name, _surname);
                }
            }
        }

        /// <summary>
        /// Фамилия персоны.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = ConvertToRightRegister(value);
                if (_name != null)
                {
                    CheckLanguage(_name, _surname);
                }
            }
        }

        /// <summary>
        /// Пол персоны.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Абстрактный возраст персоны.
        /// </summary>
        public abstract int Age { get; set; }

        //TODO: protected +

        /// <summary>
        /// Конструктор персон.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="gender">Гендер.</param>
        /// <param name="age">Возраст.</param>
        protected PersonBase(string name, string surname, Gender gender, int age)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
        }

        //TODO: protected +

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        protected PersonBase()
        { }

        //TODO: rename +

        /// <summary>
        /// Метод вывода персоны в консоль.
        /// </summary>
        /// <returns>Персона.</returns>
        public virtual string GetInfo()
        {
            return $"Имя: {_name}, фамилия: {_surname}, пол: {_gender}" +
                $" и возраст: {_age}";
        }

        /// <summary>
        /// Проверка на ввод имени или фамилии на одном языке.
        /// Возможность ввода двойного имени и фамилии.
        /// </summary>
        /// <param name="nameOrSurname">Имя или фамилия.</param>
        /// <returns>имя/фамилия.</returns>
        /// <exception cref="FormatException">CheckName.</exception>
        public static string CheckNameSurname(string nameOrSurname)
        {
            string doubleNameSurname = @"(^[А-я]+(-[А-я])?[А-я]*$)" +
                "|(^[A-z]+(-[A-z])?[A-z]*$)";
            Regex nameLanguage = new Regex(doubleNameSurname);

            if (!nameLanguage.IsMatch(nameOrSurname))
            {
                throw new FormatException("Введёное слово не распознано." +
                    " Введите еще раз!");
            }

            return nameOrSurname;
        }

        /// <summary>
        /// Преобразование верхнего регистра.
        /// </summary>
        /// <param name="surnameOrName">Имя/фамилия.</param>
        /// <returns>Имя/фамилия.</returns>
        private static string ConvertToRightRegister(string surnameOrName)
        {
            surnameOrName = surnameOrName[0].ToString().ToUpper()
                        + surnameOrName.Substring(1);

            Regex regex1 = new Regex(@"[-]");
            if (regex1.IsMatch(surnameOrName))
            {
                string[] words = surnameOrName.Split(new char[] { '-' });
                string word1 = words[0];
                string word2 = words[1];
                word1 = word1[0].ToString().ToUpper() + word1.Substring(1);
                word2 = word2[0].ToString().ToUpper() + word2.Substring(1);
                surnameOrName = word1 + "-" + word2;
            }

            return surnameOrName;
        }

        /// <summary>
        /// Сравнения языка имени и фамилии.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <exception cref="ArgumentException">ChekLenguage.</exception>
        private void CheckLanguage(string name, string surname)
        {
            Lenguage nameLang = DefineLanguage(name);
            Lenguage surnameLang = DefineLanguage(surname);
            if (nameLang != surnameLang)
            {
                throw new ArgumentException("Язык имени и фамилии" +
                    " должен совпадать.");
            }
        }

        /// <summary>
        /// Проверка на язык.
        /// </summary>
        /// <param name="word">Слово.</param>
        /// <returns>.</returns>
        /// <exception cref="ArgumentException">Слово.</exception>
        private static Lenguage DefineLanguage(string word)
        {
            Regex latin = new Regex(@"[a-zA-Z]");
            Regex cyrillic = new Regex(@"[а-яА-Я]");

            if (latin.IsMatch(word))
            {
                return Lenguage.Latin;
            }
            else if (cyrillic.IsMatch(word))
            {
                return Lenguage.Cyrillic;
            }
            else
            {
                throw new ArgumentException("Язык не распознан.\n" +
                    "Разрешено вводить только символы кирицицы и латиницы.");
            }
        }
    }
}
