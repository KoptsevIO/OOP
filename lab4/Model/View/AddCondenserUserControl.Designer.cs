namespace View
{
    /// <summary>
    /// Дизайн формы AddCondenserUserControl.
    /// </summary>
    partial class AddCapacitorUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс
        /// должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            Capacitance = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 27);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 0;
            label3.Text = "Ёмкость конденсатора";
            // 
            // Capacitance
            // 
            Capacitance.Location = new Point(168, 25);
            Capacitance.Margin = new Padding(3, 2, 3, 2);
            Capacitance.Name = "Capacitance";
            Capacitance.Size = new Size(62, 23);
            Capacitance.TabIndex = 1;
            Capacitance.KeyPress += Capacitance_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 28);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "мкФ";
            // 
            // AddCondenserUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(Capacitance);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCondenserUserControl";
            Size = new Size(300, 67);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox Capacitance;
        private Label label1;
    }
}
