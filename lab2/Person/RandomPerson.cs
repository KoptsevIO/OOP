namespace Model
{
    /// <summary>
    /// Класс RandomPerson.
    /// </summary>
    public class RandomPerson
    {
        /// <summary>
        /// Рандом.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Метод выбора Adult или Child.
        /// </summary>
        /// <returns>PersonBase.</returns>
        public static PersonBase GetAdultOrChild()
        {
            int i = _random.Next(0, 2);

            if (i == 0)
            {
                return GetRandomChild();
            }
            else
            {
                return GetRandomAdult();
            }
        }

        /// <summary>
        /// Создание рандомной персоны.
        /// </summary>
        /// <returns>Персона.</returns>
        public static PersonBase GetRandomPerson(PersonBase person,
            Gender gender = Gender.Default)
        {
            Random random = new Random();

            string[] manNames = { "Андрей", "Артём", "Вадим", "Илья",
                "Леопольд" };
            string[] womanName = { "Елена", "Екатерина", "Ангелина",
                "Наталья", "Яна" };
            string[] manSurname = { "Иванов", "Смирнов", "Соболев",
                "Кравец", "Карцев" };
            string[] womanSurname = { "Аксёнова", "Зайцева", "Набиулина",
                "Вербова", "Дзюба" };

            if (gender == Gender.Default)
            {
                person.Gender = (Gender)random.Next(2);
            }

            else
            {
                person.Gender = gender;
            }

            if (person.Gender == Gender.Male)
            {
                person.Name = manNames
                    [new Random().Next(manNames.Length)];
                person.Surname = manSurname
                    [new Random().Next(manSurname.Length)];
            }

            else
            {
                person.Name = womanName[new Random().Next(womanName.Length)];
                person.Surname = womanSurname[new Random().Next(womanSurname.Length)];
            }

            return person;

        }

        /// <summary>
        /// Создание рандомного Adult.
        /// </summary>
        /// <returns>randomAdult.</returns>
        public static Adult GetRandomAdult(MaritalStatus status = MaritalStatus.Single,
            Adult partner = null, Gender gender = Gender.Default)
        {
            Adult randomAdult = new Adult();
            GetRandomPerson(randomAdult, gender);

            randomAdult.Age = _random.Next(Adult.Min, Adult.Max);

            MaritalStatus maritalstatus = (MaritalStatus)_random.Next(2);
            randomAdult.MaritalStatus = maritalstatus;

            if (maritalstatus == MaritalStatus.Married)
            {
                if (randomAdult.Gender == Gender.Male)
                {
                    randomAdult.Partner = GetRandomAdult(
                        MaritalStatus.Married, randomAdult, Gender.Female);
                }

                else
                {
                    randomAdult.Partner = GetRandomAdult(
                        MaritalStatus.Married, randomAdult, Gender.Male);
                }
            }

            else
            {
                randomAdult.MaritalStatus = status;
            }

            string[] work = { "Сфетофор.", "Командор.", "Абрикос.",
                "Пятёрочка.", "Полюс.", "РУСАЛ." };

            var getWork = _random.Next(0, 4);

            if (getWork > 0)
            {
                randomAdult.Workplace = work[_random.Next(0, work.Length)];
            }

            int[] passportSerie = { 4452, 4352, 4252, 4152 };
            int[] passportNumber = { 842156, 832156, 954123, 852156 };

            var getPassport = _random.Next();

            if (getPassport > 0)
            {
                randomAdult.PassportSerie = passportSerie[_random.Next(0,
                    passportSerie.Length)];
                randomAdult.PassportNumber = passportNumber[_random.Next(0,
                    passportNumber.Length)];
            }

            return randomAdult;
        }

        /// <summary>
        /// Метод создания рандомного Child.
        /// </summary>
        /// <returns>randomChild.</returns>
        public static Child GetRandomChild()
        {
            Child randomChild = new Child();
            GetRandomPerson(randomChild);

            randomChild.Age = _random.Next
                (Child.Min, Child.Max);

            var hasMom = _random.Next(0, 5);

            if (hasMom > 0)
            {
                randomChild.Mom = GetRandomAdult
                    (MaritalStatus.Married, randomChild.Dad,
                    Gender.Female);
            }

            var hasDad = _random.Next(0, 5);

            if (hasDad > 0)
            {
                randomChild.Dad = GetRandomAdult
                    (MaritalStatus.Married, randomChild.Mom, Gender.Male);
            }

            string[] kindergartenName = {
                "Детский ад \"Дельфин\".", "Детский ад \"Русалочка\".",
                "Детский ад \"Морячок\".", "Детский ад \"Яблочко\"." };

            string[] schoolName = {
                "МБОУ СОШ №5.", "Лицей №7.", "МБОУ СОШ №1.", "Гимназия №3." };

            var hasEducationLevel = _random.Next(0, 4);

            if (hasEducationLevel > 0)
            {
                if (randomChild.Age > 1 && randomChild.Age < 8)
                {
                    randomChild.EducationLevel = kindergartenName
                        [_random.Next(1, kindergartenName.Length)];
                }
                else
                {
                    randomChild.EducationLevel = schoolName
                        [_random.Next(1, schoolName.Length)];
                }
            }

            return randomChild;
        }
    }
}
