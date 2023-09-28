﻿using PassiveElement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Форма фильтрации.
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Лист фильтруемых фигур
        /// </summary>
        private BindingList<PassiveElementBase> _listElement;

        /// <summary>
        /// Лист отфильтрованных фигур
        /// </summary>
        private BindingList<PassiveElementBase> _listElementsFilter;

        //TODO: duplication
        /// <summary>
        /// Вещественная часть комплексного сопротивления.
        /// </summary>
        private double impedance1;

        /// <summary>
        /// Мнимая часть комплексного сопротивления.
        /// </summary>
        private double impedance2;

        /// <summary>
        /// Комплексное сопротивление.
        /// </summary>
        private Complex impedance;

        /// <summary>
        /// Обработчик события.
        /// </summary>
        public EventHandler<EventArgs> ElementFiltered;

        /// <summary>
        /// Инициализация форм.
        /// </summary>
        public FilterForm(BindingList<PassiveElementBase> elements)
        {
            InitializeComponent();
            _listElement = elements;
            //TODO: rename
            ImpedanceTextBox.Enabled = false;
            ImpedanceTextBox2.Enabled = false;
        }

        /// <summary>
        /// Ввод вещественного
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void textBoxImpedance_TextChanged(object sender,
            EventArgs e)
        {
            try
            {
                if (ImpedanceTextBox.Text != "")
                {
                    impedance = 
                        Utils.CheckNumber(ImpedanceTextBox.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введите корректное число!",
                    "Ошибка!", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ввод мнимого
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void textBoxImpedance2_TextChanged(object sender,
            EventArgs e)
        {
            try
            {
                if (ImpedanceTextBox2.Text != "")
                {
                    impedance = 
                        Utils.CheckNumber(ImpedanceTextBox.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введите корректное число!",
                    "Ошибка!", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Флажок активации поля ввода сопротивления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender,
            EventArgs e)
        {
            if (ImpedanceCheckBox.Checked)
            {
                ImpedanceTextBox.Enabled = true;
                ImpedanceTextBox2.Enabled = true;
            }
        }

        /// <summary>
        /// Кнопка поиска.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            _listElementsFilter = new BindingList<PassiveElementBase>();
            int count = 0;

            if (!InductorCheckBox.Checked
                && !ResistorCheckBox.Checked
                && !CondenserCheckBox.Checked
                && !ImpedanceCheckBox.Checked)
            {
                MessageBox.Show("Критерии для поиска не введены!",
                    "Внимание", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            foreach (PassiveElementBase element in _listElement)
            {

                switch (element)
                {
                    case Resistor when ResistorCheckBox.Checked:
                    case Condenser when CondenserCheckBox.Checked:
                    case Inductor when InductorCheckBox.Checked:
                        {
                            if (ImpedanceCheckBox.Checked)
                            {
                                impedance = new Complex(impedance1,
                                    impedance2);
                                if (element.Impedance == impedance)
                                {
                                    count++;
                                    _listElementsFilter.Add(element);
                                    break;
                                }
                                break;
                            }
                            else
                            {
                                count++;
                                _listElementsFilter.Add(element);
                                break;
                            }
                        }
                }

                if (!InductorCheckBox.Checked
                    && !ResistorCheckBox.Checked
                    && !CondenserCheckBox.Checked)
                {
                    if (ImpedanceCheckBox.Checked &&
                        element.Impedance == impedance)
                    {
                        count++;
                        _listElementsFilter.Add(element);
                    }
                }
            }

            ElementListEventArgs eventArgs;

            if (count > 0)
            {
                eventArgs = new ElementListEventArgs(_listElementsFilter);
            }
            else
            {
                MessageBox.Show("Нет фигур удовлетворяющих фильтру!",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                eventArgs = new ElementListEventArgs(_listElementsFilter);
                return;
            }

            ElementFiltered?.Invoke(this, eventArgs);
            Close();
        }
    }
}
