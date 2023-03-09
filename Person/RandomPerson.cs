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
        public static Person GetRandomPerson()
        {
            Person person = new Person();
            Random random = new Random();

            //TODO: RSDN
            string[] man_name = { "Андрей", "Артём", "Вадим", "Илья", "Леопольд" };
            string[] woman_name = { "Елена", "Екатерина", "Ангелина", "Наталья", "Яна" };
            string[] man_surname = { "Иванов", "Смирнов", "Соболев", "Кравец", "Карцев" };
            string[] woman_surname = { "Аксёнова", "Зайцева", "Набиулина", "Вербова", "Дзюба" };

            person.Age = random.Next(Person.Min, Person.Max);
            person.Gender = (Gender)random.Next(2);

            if (person.Gender == Gender.Male)
            {
                person.Name = man_name[new Random().Next(man_name.Length)];
                person.Surname = man_surname[new Random().Next(man_surname.Length)];
            }

            else
            {
                person.Name = woman_name[new Random().Next(woman_name.Length)];
                person.Surname = woman_surname[new Random().Next(woman_surname.Length)];
            }

            return person;

        }
    }
}
