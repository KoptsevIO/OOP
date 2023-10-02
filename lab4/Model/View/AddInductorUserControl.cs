using System;
using PassiveElement;
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
    /// Класс параметров катушки индуктивности.
    /// </summary>
    public partial class AddInductorUserControl : UserControl,
        IAddElement
    {
        /// <summary>
        /// Добавление параметров катушки индуктивности.
        /// </summary>
        public AddInductorUserControl()
        {
            InitializeComponent();
        }

        //TODO: remove +

        /// <summary>
        /// Метод добавления индуктивности.
        /// </summary>
        /// <returns>inductor.</returns>
        public PassiveElementBase AddElement()
        {
            var inductor = new Inductor();

            inductor.Inductance = Utils.CheckNumber(Inductance.Text);

            return inductor;
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void Inductance_KeyPress(object sender,
            KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

    }
}
