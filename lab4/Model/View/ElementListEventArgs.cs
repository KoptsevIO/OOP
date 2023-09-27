using System;
using PassiveElement;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace View
{
    /// <summary>
    /// Класс событий.
    /// </summary>
    public class ElementListEventArgs : EventArgs
    {
        /// <summary>
        /// Свойство список элементов.
        /// </summary>
        public BindingList<PassiveElementBase> ElementList 
        { get; set; }

        /// <summary>
        /// Список элементов.
        /// </summary>
        /// <param name="element">Элемент.</param>
        public ElementListEventArgs(BindingList<PassiveElementBase> 
            element)
        {
            ElementList = element;
        }

    }
}
