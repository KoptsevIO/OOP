using System.Text.RegularExpressions;

namespace Model
{
    public class Person
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Пол.
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Возраст.
        /// </summary>
        private int _age;

        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        private const int _min = 1;

        /// <summary>
        /// Максимальный возраст.
        /// </summary>
        private const int _max = 90;

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
        public Gender Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        /// <summary>
        /// Возраст персоны.
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value > _max || value < _min)
                {
                    throw new ArgumentException($"Введён некорректный" +
                        $" возвраст, введите возраст" +
                        $" от {_min} до {_max} лет!");
                }
                else
                {
                    _age = value;
                }
            }
        }

        /// <summary>
        /// Конструктор персон.
        /// </summary>
        public Person(string name, string surname, Gender gender, int age)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
        }

        /// <summary>
        /// Конструктор персон 2.
        /// </summary>
        public Person()
        { }

        /// <summary>
        /// Метод вывода персоны в консоль.
        /// </summary>
        /// <returns>.</returns>
        public string PersonOutputConsole()
        {
            return $"Имя: {_name}, фамилия: {_surname}, пол: {_gender}" +
                $" и возраст: {_age}";
        }

        /// <summary>
        /// Проверка на ввод имени или фамилии на одном языке.
        /// Возможность ввода двойного имени и фамилии.
        /// </summary>
        /// <param name="nameOrSurname">.</param>
        /// <returns>.</returns>
        /// <exception cref="FormatException">.</exception>
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
        /// Преобразование регистра первой буквы.
        /// </summary>
        /// <returns>.</returns>
        public static string ConvertToRightRegister(string surnameOrName)
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
        /// <param name="name">.</param>
        /// <param name="surname">.</param>
        /// <exception cref="ArgumentException">.</exception>
        public void CheckLanguage(string name, string surname)
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
        /// <param name="word">.</param>
        /// <returns>.</returns>
        /// <exception cref="ArgumentException">.</exception>
        public static Lenguage DefineLanguage(string word)
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
