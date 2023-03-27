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
        public static PersonBase AdultOrChild()
        {
            int i = _random.Next(0, 1);

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

            string[] job = { "SO \"UES\" ", "RusGidro", "Sberbank",
                "Bakery \"Plump bun\"", "Norilsk Nickel", "Rosbank" };

            var getjob = _random.Next(0, 4);

            if (getjob > 0)
            {
                randomAdult.Workplace = job[_random.Next(0, job.Length)];
            }

            var passportSerie = _random.Next
                (Adult.PassportSerieMin, Adult.PassportSerieMax);
            randomAdult.PassportSerie = passportSerie;

            var passportNumber = _random.Next
                (Adult.PassportNumberMin, Adult.PassportNumberMax);
            randomAdult.PassportNumber = passportNumber;

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

            string[] kindergarten = {
                "Kindergarten \"Rucheek\"", "Kindergarten \"Dandelion\"",
                "Kindergarten \"Sunny\"", "Kindergarten \"Cucumbers\"" };

            string[] school = {
                "Forks High School", "The Cambridge School of Weston",
                "Mystic Falls High School", "Beacon Hills High School" };

            var hasInstitution = _random.Next(0, 4);

            if (hasInstitution > 0)
            {
                if (randomChild.Age < 8)
                {
                    randomChild.EducationLevel = kindergarten
                        [_random.Next(1, kindergarten.Length)];
                }
                else
                {
                    randomChild.EducationLevel = school
                        [_random.Next(1, school.Length)];
                }
            }

            return randomChild;
        }
    }
}
