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
            label2 = new Label();
            Inductance = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 34);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 0;
            label2.Text = "Индуктивность";
            label2.Click += label2_Click;
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
            Controls.Add(label2);
            Name = "AddInductorUserControl";
            Size = new Size(402, 89);
            Load += AddInductorUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox Inductance;
    }
}
