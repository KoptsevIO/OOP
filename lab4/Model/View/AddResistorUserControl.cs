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
    /// Добавление параметров резистора на форму AddResistorUserControl.
    /// </summary>
    public partial class AddResistorUserControl : UserControl, IAddElement
    {
        /// <summary>
        /// Добавление параллелепипеда.
        /// </summary>
        public AddResistorUserControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void Resistance_TextChanged(object sender, EventArgs e)
        { }

        private void AddResistorUserControl_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Метод добавления резистора.
        /// </summary>
        /// <returns>resistor.</returns>
        public PassiveElementBase AddElement()
        {
            var resistor = new Resistor();

            return resistor;
        }
    }
}
