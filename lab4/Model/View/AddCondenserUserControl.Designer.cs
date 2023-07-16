namespace View
{
    /// <summary>
    /// Дизайн формы AddCondenserUserControl.
    /// </summary>
    partial class AddCondenserUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 36);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 0;
            label3.Text = "Ёмкость конденсатора";
            // 
            // Capacitance
            // 
            Capacitance.Location = new Point(234, 33);
            Capacitance.Name = "Capacitance";
            Capacitance.Size = new Size(147, 27);
            Capacitance.TabIndex = 1;
            Capacitance.KeyPress += Capacitance_KeyPress;
            // 
            // AddCondenserUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Capacitance);
            Controls.Add(label3);
            Name = "AddCondenserUserControl";
            Size = new Size(402, 89);
            Load += AddCondenserUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox Capacitance;
    }
}
