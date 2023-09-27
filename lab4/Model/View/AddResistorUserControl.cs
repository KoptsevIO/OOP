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
    /// Добавление параметров резистора на форму 
    /// AddResistorUserControl.
    /// </summary>
    public partial class AddResistorUserControl : UserControl, 
        IAddElement
    {
        /// <summary>
        /// Добавление параллелепипеда.
        /// </summary>
        public AddResistorUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление индуктивности.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void AddResistorUserControl_Load(object sender, 
            EventArgs e)
        { }

        /// <summary>
        /// Метод добавления резистора.
        /// </summary>
        /// <returns>resistor.</returns>
        public PassiveElementBase AddElement()
        {
            var resistor = new Resistor();

            resistor.Resistance = Checks.CheckNumber(Resistance.Text);

            return resistor;
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void Resistance_KeyPress(object sender, 
            KeyPressEventArgs e)
        {
            Checks.CheckInput(e);
        }

    }
}
