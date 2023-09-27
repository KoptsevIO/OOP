namespace View
{
    /// <summary>
    /// Класс-дизайнер формы фильтра.
    /// </summary>
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            filterGroupBox = new GroupBox();
            CondenserCheckBox = new CheckBox();
            InductorCheckBox = new CheckBox();
            ResistorCheckBox = new CheckBox();
            filterButton = new Button();
            ImpedanceCheckBox = new CheckBox();
            ImpedanceTextBox = new TextBox();
            Impedancelabel = new Label();
            filterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // filterGroupBox
            // 
            filterGroupBox.BackColor = SystemColors.Control;
            filterGroupBox.Controls.Add(CondenserCheckBox);
            filterGroupBox.Controls.Add(InductorCheckBox);
            filterGroupBox.Controls.Add(ResistorCheckBox);
            filterGroupBox.Location = new Point(10, 21);
            filterGroupBox.Margin = new Padding(3, 2, 3, 2);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Padding = new Padding(3, 2, 3, 2);
            filterGroupBox.Size = new Size(190, 110);
            filterGroupBox.TabIndex = 0;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Параметры фильтрации";
            filterGroupBox.Enter += filterGroupBox_Enter;
            // 
            // CondenserCheckBox
            // 
            CondenserCheckBox.AutoSize = true;
            CondenserCheckBox.Location = new Point(10, 88);
            CondenserCheckBox.Margin = new Padding(3, 2, 3, 2);
            CondenserCheckBox.Name = "CondenserCheckBox";
            CondenserCheckBox.Size = new Size(97, 19);
            CondenserCheckBox.TabIndex = 2;
            CondenserCheckBox.Text = "Конденсатор";
            CondenserCheckBox.UseVisualStyleBackColor = true;
            CondenserCheckBox.CheckedChanged += condenserCheckBox_CheckedChanged;
            // 
            // InductorCheckBox
            // 
            InductorCheckBox.AutoSize = true;
            InductorCheckBox.Location = new Point(10, 57);
            InductorCheckBox.Margin = new Padding(3, 2, 3, 2);
            InductorCheckBox.Name = "InductorCheckBox";
            InductorCheckBox.Size = new Size(158, 19);
            InductorCheckBox.TabIndex = 1;
            InductorCheckBox.Text = "Катушка индуктивности";
            InductorCheckBox.UseVisualStyleBackColor = true;
            InductorCheckBox.CheckedChanged += iductanceCheckBox_CheckedChanged;
            // 
            // ResistorCheckBox
            // 
            ResistorCheckBox.AutoSize = true;
            ResistorCheckBox.Location = new Point(10, 26);
            ResistorCheckBox.Margin = new Padding(3, 2, 3, 2);
            ResistorCheckBox.Name = "ResistorCheckBox";
            ResistorCheckBox.Size = new Size(76, 19);
            ResistorCheckBox.TabIndex = 0;
            ResistorCheckBox.Text = "Резистор";
            ResistorCheckBox.UseVisualStyleBackColor = true;
            ResistorCheckBox.CheckedChanged += resistanceCheckBox_CheckedChanged;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(8, 170);
            filterButton.Margin = new Padding(3, 2, 3, 2);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(216, 22);
            filterButton.TabIndex = 1;
            filterButton.Text = "Запуск фильтрации";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // ImpedanceCheckBox
            // 
            ImpedanceCheckBox.AutoSize = true;
            ImpedanceCheckBox.Location = new Point(20, 142);
            ImpedanceCheckBox.Margin = new Padding(3, 2, 3, 2);
            ImpedanceCheckBox.Name = "ImpedanceCheckBox";
            ImpedanceCheckBox.Size = new Size(113, 19);
            ImpedanceCheckBox.TabIndex = 3;
            ImpedanceCheckBox.Text = "Сопротивление";
            ImpedanceCheckBox.UseVisualStyleBackColor = true;
            ImpedanceCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ImpedanceTextBox
            // 
            ImpedanceTextBox.Location = new Point(138, 140);
            ImpedanceTextBox.Margin = new Padding(3, 2, 3, 2);
            ImpedanceTextBox.Name = "ImpedanceTextBox";
            ImpedanceTextBox.Size = new Size(86, 23);
            ImpedanceTextBox.TabIndex = 4;
            // 
            // Impedancelabel
            // 
            Impedancelabel.AutoSize = true;
            Impedancelabel.Location = new Point(199, 109);
            Impedancelabel.Name = "Impedancelabel";
            Impedancelabel.Size = new Size(25, 15);
            Impedancelabel.TabIndex = 5;
            Impedancelabel.Text = "Ом";
            Impedancelabel.Click += label1_Click;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 201);
            Controls.Add(Impedancelabel);
            Controls.Add(ImpedanceTextBox);
            Controls.Add(ImpedanceCheckBox);
            Controls.Add(filterButton);
            Controls.Add(filterGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FilterForm";
            Text = "Фильтр";
            filterGroupBox.ResumeLayout(false);
            filterGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox filterGroupBox;
        private Button filterButton;
        private CheckBox InductorCheckBox;
        private CheckBox ResistorCheckBox;
        private CheckBox CondenserCheckBox;
        private CheckBox ImpedanceCheckBox;
        private TextBox ImpedanceTextBox;
        private Label Impedancelabel;
    }
}