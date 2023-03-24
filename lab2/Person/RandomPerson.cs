namespace Model
{
    /// <summary>
    /// Класс RandomPerson.
    /// </summary>
    public class RandomPerson
    {
        /// <summary>
        /// Создание рандомной персоны.
        /// </summary>
        /// <returns>Персона.</returns>
        public static PersonBase GetRandomPerson()
        {
            PersonBase person = new PersonBase();
            Random random = new Random();

            string[] manNames = { "Андрей", "Артём", "Вадим", "Илья", "Леопольд" };
            string[] womanName = { "Елена", "Екатерина", "Ангелина", "Наталья", "Яна" };
            string[] manSurname = { "Иванов", "Смирнов", "Соболев", "Кравец", "Карцев" };
            string[] womanSurname = { "Аксёнова", "Зайцева", "Набиулина", "Вербова", "Дзюба" };

            person.Age = random.Next(PersonBase.Min, PersonBase.Max);
            person.Gender = (Gender)random.Next(2);

            if (person.Gender == Gender.Male)
            {
                person.Name = manNames[new Random().Next(manNames.Length)];
                person.Surname = manSurname[new Random().Next(manSurname.Length)];
            }

            else
            {
                person.Name = womanName[new Random().Next(womanName.Length)];
                person.Surname = womanSurname[new Random().Next(womanSurname.Length)];
            }

            return person;

        }
    }
}
