namespace Model
{
    /// <summary>
    /// Класс список персон.
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Список персон.
        /// </summary>
        private List<Person> _people = new List<Person>();

        /// <summary>
        /// Добавление персон в список.
        /// </summary>
        /// <param name="person">.</param>
        public void Add(Person person)
        {
            _people.Add(person);
        }

        /// <summary>
        /// Удаление элемента по возрасту.
        /// </summary>
        /// <param name="age">.</param>
        public void PeopleRemoveAge(int age)
        {
            _people.RemoveAll(i => i.Age == age);
        }

        /// <summary>
        /// Удаление элемента по индексу.
        /// </summary>
        /// <param name="index">.</param>
        public void PeopleRemoveAt(int index)
        {
            _people.RemoveAt(index);
        }

        /// <summary>
        /// Поиск элемента по индексу.
        /// </summary>
        /// <param name="index">.</param>
        /// <returns>.</returns>
        public Person PeopleFindByIndex(int index)
        {
            return _people.ElementAt(index);
        }

        /// <summary>
        /// Возврат индекса списка по возрасту.
        /// </summary>
        /// <param name="age">.</param>
        /// <returns>.</returns>
        public int PeopleFindByAge(int age)
        {
            return _people.FindIndex(i => i.Age == age);
        }

        /// <summary>
        /// Удаление списка персон.
        /// </summary>
        public void PeopleClear()
        {
            _people.Clear();
        }

        /// <summary>
        /// Получение кол-ва элементов списка.
        /// </summary>
        /// <returns>.</returns>
        public int PeopleCount()
        {
            return _people.Count;
        }

    }
}
