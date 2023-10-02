using PassiveElement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    //TODO: rename +
    /// <summary>
    /// Класс добавления параетров конденсатора. 
    /// </summary>
    public partial class AddCapacitorUserControl : UserControl,
        IAddElement
    {
        /// <summary>
        /// Добавление параметров конденаторов.
        /// </summary>
        public AddCapacitorUserControl()
        {
            InitializeComponent();
        }

        //TODO: remove +

        /// <summary>
        /// Метод добавления конденсатора.
        /// </summary>
        /// <returns>Capacitor.</returns>
        public PassiveElementBase AddElement()
        {
            var сapacitor = new Capacitor();

            сapacitor.Capacity = Utils.CheckNumber(Capacitance.Text);

            return сapacitor;
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void Capacitance_KeyPress(object sender,
            KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }
    }
}
