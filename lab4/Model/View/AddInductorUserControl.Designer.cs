namespace View
{
    /// <summary>
    /// Дизайн формы AddInductorUserControl.
    /// </summary>
    partial class AddInductorUserControl
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
            label1 = new Label();
            Inductance = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 34);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Индуктивность";
            label1.Click += label1_Click;
            // 
            // Inductance
            // 
            Inductance.Location = new Point(234, 33);
            Inductance.Name = "Inductance";
            Inductance.Size = new Size(147, 27);
            Inductance.TabIndex = 1;
            Inductance.TextChanged += Inductance_TextChanged;
            // 
            // AddInductorUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Inductance);
            Controls.Add(label1);
            Name = "AddInductorUserControl";
            Size = new Size(402, 89);
            Load += AddInductorUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Inductance;
    }
}
