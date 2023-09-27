using System.Windows.Forms;

namespace View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            deletElement = new Button();
            addElement = new Button();
            groupBoxElements = new GroupBox();
            buttonDeleteElements = new Button();
            dataGridView1 = new DataGridView();
            buttonReset = new Button();
            buttonFilterElement = new Button();
            groupBoxElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // deletElement
            // 
            deletElement.Location = new Point(16, 250);
            deletElement.Margin = new Padding(3, 2, 3, 2);
            deletElement.Name = "deletElement";
            deletElement.Size = new Size(198, 29);
            deletElement.TabIndex = 5;
            deletElement.Text = "Удалить элемент";
            deletElement.UseVisualStyleBackColor = true;
            deletElement.Click += deletElement_Click;
            // 
            // addElement
            // 
            addElement.Location = new Point(25, 238);
            addElement.Margin = new Padding(3, 2, 3, 2);
            addElement.Name = "addElement";
            addElement.Size = new Size(198, 29);
            addElement.TabIndex = 4;
            addElement.Text = "Добавить элемент";
            addElement.UseVisualStyleBackColor = true;
            addElement.Click += addElement_Click;
            // 
            // groupBoxElements
            // 
            groupBoxElements.Controls.Add(buttonDeleteElements);
            groupBoxElements.Controls.Add(dataGridView1);
            groupBoxElements.Controls.Add(buttonReset);
            groupBoxElements.Controls.Add(buttonFilterElement);
            groupBoxElements.Controls.Add(deletElement);
            groupBoxElements.Location = new Point(10, 24);
            groupBoxElements.Margin = new Padding(3, 2, 3, 2);
            groupBoxElements.Name = "groupBoxElements";
            groupBoxElements.Padding = new Padding(3, 2, 3, 2);
            groupBoxElements.Size = new Size(505, 288);
            groupBoxElements.TabIndex = 3;
            groupBoxElements.TabStop = false;
            groupBoxElements.Text = "Список элементов";
            // 
            // buttonDeleteElements
            // 
            buttonDeleteElements.Location = new Point(225, 215);
            buttonDeleteElements.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteElements.Name = "buttonDeleteElements";
            buttonDeleteElements.Size = new Size(150, 64);
            buttonDeleteElements.TabIndex = 8;
            buttonDeleteElements.Text = "Добавить случайный элемент";
            buttonDeleteElements.UseVisualStyleBackColor = true;
            buttonDeleteElements.Click += buttonDeleteElements_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 20);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(466, 190);
            dataGridView1.TabIndex = 0;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(387, 250);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonFilterElement
            // 
            buttonFilterElement.Location = new Point(387, 215);
            buttonFilterElement.Margin = new Padding(3, 2, 3, 2);
            buttonFilterElement.Name = "buttonFilterElement";
            buttonFilterElement.Size = new Size(94, 28);
            buttonFilterElement.TabIndex = 6;
            buttonFilterElement.Text = "Фильтр";
            buttonFilterElement.UseVisualStyleBackColor = true;
            buttonFilterElement.Click += buttonFilterElement_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 326);
            Controls.Add(addElement);
            Controls.Add(groupBoxElements);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Программа расчёта комплексного сопротивлениия";
            TransparencyKey = Color.White;
            Load += MainForm_Load;
            groupBoxElements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button deletElement;
        private Button addElement;
        private GroupBox groupBoxElements;
        private Button buttonFilterElement;
        private Button buttonReset;
        private DataGridView dataGridView1;
        private Button buttonDeleteElements;
    }
}