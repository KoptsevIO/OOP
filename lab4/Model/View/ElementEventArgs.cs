using PassiveElement;

namespace View
{
    /// <summary>
    /// Класс событий.
    /// </summary>
    public class ElementEventArgs : EventArgs
    {
        /// <summary>
        /// Класс пассивных элементов.
        /// </summary>
        public PassiveElementBase Element { get; private set; }
        
        /// <summary>
        /// Вызов элементов.
        /// </summary>
        /// <param name="element">Элемент.</param>
        public ElementEventArgs(PassiveElementBase element)
        {
            Element = element;
        }
    }
}
