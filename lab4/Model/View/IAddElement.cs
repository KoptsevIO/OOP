using System;
using PassiveElement;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    /// <summary>
    /// Интерфейс добавления пассивных элементов.
    /// </summary>
    public interface IAddElement
    {
        /// <summary>
        /// Метод добавления элементов.
        /// </summary>
        /// <returns>.</returns>
        public abstract PassiveElementBase AddElement();
    }
}
