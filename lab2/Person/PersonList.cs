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
        private List<PersonBase> _people = new List<PersonBase>();

        /// <summary>
        /// Добавление персон в список.
        /// </summary>
        /// <param name="person">Персона.</param>
        public void Add(PersonBase person)
        {
            _people.Add(person);
        }

        /// <summary>
        /// Удаление элемента по возрасту.
        /// </summary>
        /// <param name="age">Возраст.</param>
        public void PeopleRemoveAge(int age)
        {
            _people.RemoveAll(i => i.Age == age);
        }

        /// <summary>
        /// Удаление элемента по индексу.
        /// </summary>
        /// <param name="index">Индекс.</param>
        public void PeopleRemoveAt(int index)
        {
            _people.RemoveAt(index);
        }

        /// <summary>
        /// Поиск элемента по индексу.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Элемемент списка.</returns>
        public PersonBase PeopleFindByIndex(int index)
        {
            return _people.ElementAt(index);
        }

        /// <summary>
        /// Возврат индекса списка по возрасту.
        /// </summary>
        /// <param name="age">Возраст.</param>
        /// <returns>Индекс.</returns>
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
        /// <returns>Кол-во элементов списка.</returns>
        public int PeopleCount()
        {
            return _people.Count;
        }

    }
}
