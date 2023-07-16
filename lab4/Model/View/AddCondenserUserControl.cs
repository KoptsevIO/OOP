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
    /// <summary>
    /// Класс добавления параетров конденсатора. 
    /// </summary>
    public partial class AddCondenserUserControl : UserControl, IAddElement
    {
        /// <summary>
        /// Добавление параметров конденаторов.
        /// </summary>
        public AddCondenserUserControl()
        {
            InitializeComponent();
        }

        private void AddCondenserUserControl_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Метод добавления конденсатора.
        /// </summary>
        /// <returns>condenser.</returns>
        public PassiveElementBase AddElement()
        {
            var condenser = new Condenser();

            condenser.Capacity = Checks.CheckNumber(Capacitance.Text);

            return condenser;
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Capacitance_KeyPress(object sender, KeyPressEventArgs e)
        {
            Checks.CheckInput(e);
        }
    }
}
