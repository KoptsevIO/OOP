﻿namespace View
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
            addResistorUserControl1 = new AddResistorUserControl();
            addInductorUserControl1 = new AddInductorUserControl();
            addCondenserUserControl1 = new AddCondenserUserControl();
            choicElementComboBox = new ComboBox();
            canselButton = new Button();
            confirmationButton = new Button();
            choicElementGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // choicElementGroupBox
            // 
            choicElementGroupBox.Controls.Add(addResistorUserControl1);
            choicElementGroupBox.Controls.Add(addInductorUserControl1);
            choicElementGroupBox.Controls.Add(addCondenserUserControl1);
            choicElementGroupBox.Controls.Add(choicElementComboBox);
            choicElementGroupBox.Location = new Point(25, 27);
            choicElementGroupBox.Name = "choicElementGroupBox";
            choicElementGroupBox.Size = new Size(556, 263);
            choicElementGroupBox.TabIndex = 0;
            choicElementGroupBox.TabStop = false;
            choicElementGroupBox.Text = "Выбор элемента";
            // 
            // addResistorUserControl1
            // 
            addResistorUserControl1.Location = new Point(54, 95);
            addResistorUserControl1.Name = "addResistorUserControl1";
            addResistorUserControl1.Size = new Size(502, 111);
            addResistorUserControl1.TabIndex = 5;
            // 
            // addInductorUserControl1
            // 
            addInductorUserControl1.Location = new Point(48, 95);
            addInductorUserControl1.Name = "addInductorUserControl1";
            addInductorUserControl1.Size = new Size(502, 111);
            addInductorUserControl1.TabIndex = 4;
            // 
            // addCondenserUserControl1
            // 
            addCondenserUserControl1.Location = new Point(38, 95);
            addCondenserUserControl1.Name = "addCondenserUserControl1";
            addCondenserUserControl1.Size = new Size(502, 111);
            addCondenserUserControl1.TabIndex = 3;
            // 
            // choicElementComboBox
            // 
            choicElementComboBox.FormattingEnabled = true;
            choicElementComboBox.Location = new Point(12, 29);
            choicElementComboBox.Name = "choicElementComboBox";
            choicElementComboBox.Size = new Size(203, 28);
            choicElementComboBox.TabIndex = 2;
            choicElementComboBox.SelectedIndexChanged += choicElementComboBox_SelectedIndexChanged;
            // 
            // canselButton
            // 
            canselButton.Location = new Point(170, 296);
            canselButton.Name = "canselButton";
            canselButton.Size = new Size(130, 29);
            canselButton.TabIndex = 1;
            canselButton.Text = "Отмена";
            canselButton.UseVisualStyleBackColor = true;
            canselButton.Click += canselButton_Click;
            // 
            // confirmationButton
            // 
            confirmationButton.Location = new Point(25, 296);
            confirmationButton.Name = "confirmationButton";
            confirmationButton.Size = new Size(130, 29);
            confirmationButton.TabIndex = 0;
            confirmationButton.Text = "OK";
            confirmationButton.UseVisualStyleBackColor = true;
            confirmationButton.Click += confirmationButton_Click;
            // 
            // AddElementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 331);
            Controls.Add(choicElementGroupBox);
            Controls.Add(canselButton);
            Controls.Add(confirmationButton);
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
        private AddResistorUserControl addResistorUserControl1;
        private AddInductorUserControl addInductorUserControl1;
        private AddCondenserUserControl addCondenserUserControl1;
    }
}