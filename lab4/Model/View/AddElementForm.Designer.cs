namespace View
{
    partial class AddElementForm
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
            choicElementGroupBox = new GroupBox();
            choicElementComboBox = new ComboBox();
            canselButton = new Button();
            confirmationButton = new Button();
            choicElementGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // choicElementGroupBox
            // 
            choicElementGroupBox.Controls.Add(choicElementComboBox);
            choicElementGroupBox.Controls.Add(canselButton);
            choicElementGroupBox.Controls.Add(confirmationButton);
            choicElementGroupBox.Location = new Point(25, 27);
            choicElementGroupBox.Name = "choicElementGroupBox";
            choicElementGroupBox.Size = new Size(282, 229);
            choicElementGroupBox.TabIndex = 0;
            choicElementGroupBox.TabStop = false;
            choicElementGroupBox.Text = "Выбор элемента";
            // 
            // choicElementComboBox
            // 
            choicElementComboBox.FormattingEnabled = true;
            choicElementComboBox.Location = new Point(12, 29);
            choicElementComboBox.Name = "choicElementComboBox";
            choicElementComboBox.Size = new Size(203, 28);
            choicElementComboBox.TabIndex = 2;
            // 
            // canselButton
            // 
            canselButton.Location = new Point(141, 186);
            canselButton.Name = "canselButton";
            canselButton.Size = new Size(130, 29);
            canselButton.TabIndex = 1;
            canselButton.Text = "Отмена";
            canselButton.UseVisualStyleBackColor = true;
            // 
            // confirmationButton
            // 
            confirmationButton.Location = new Point(6, 186);
            confirmationButton.Name = "confirmationButton";
            confirmationButton.Size = new Size(130, 29);
            confirmationButton.TabIndex = 0;
            confirmationButton.Text = "OK";
            confirmationButton.UseVisualStyleBackColor = true;
            // 
            // AddElementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 264);
            Controls.Add(choicElementGroupBox);
            Name = "AddElementForm";
            Text = "Добавить элемент";
            Load += AddElementForm_Load;
            choicElementGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox choicElementGroupBox;
        private Button canselButton;
        private Button confirmationButton;
        private ComboBox choicElementComboBox;
    }
}