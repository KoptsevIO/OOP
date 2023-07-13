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
    public partial class AddElementForm : Form
    {
        private readonly Dictionary<string, UserControl>
            dictionaryUserControl;

        /// <summary>
        /// Метка используемого UserControl.
        /// </summary>
        private UserControl userControl;

        public AddElementForm()
        {
            InitializeComponent();

            choicElementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            confirmationButton.Enabled = false;
#if !DEBUG
            button3.Visible = false;
#endif
            string[] elements = { "Резистор", "Индуктивность", "Конденсатор" };

            choicElementComboBox.Items.AddRange(new string[]
                 { elements[0], elements[1], elements[2] });

            dictionaryUserControl = new Dictionary<string, UserControl>()
            {
                {elements[0], addResistorUserControl1},
                {elements[1], addInductorUserControl1},
                {elements[2], addCondenserUserControl1}
            };
        }

        private void AddElementForm_Load(object sender, EventArgs e)
        {
            addResistorUserControl1.Visible = false;
            addInductorUserControl1.Visible = false;
            addCondenserUserControl1.Visible = false;
        }

        private void choicElementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string elementType = choicElementComboBox.SelectedItem.ToString();

            foreach (var (i, userControl) in dictionaryUserControl)
            {
                userControl.Visible = false;
                if (elementType == i)
                {
                    userControl.Visible = true;
                    confirmationButton.Enabled = true;
                    this.userControl = userControl;
                }
            }

        }

        private void confirmationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
