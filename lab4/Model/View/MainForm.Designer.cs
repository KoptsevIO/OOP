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
            groupBoxMain = new GroupBox();
            addElement = new Button();
            groupBoxElements = new GroupBox();
            deletElement = new Button();
            groupBoxMain.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain
            // 
            groupBoxMain.Controls.Add(deletElement);
            groupBoxMain.Controls.Add(addElement);
            groupBoxMain.Controls.Add(groupBoxElements);
            groupBoxMain.Location = new Point(16, 31);
            groupBoxMain.Name = "groupBoxMain";
            groupBoxMain.Size = new Size(573, 391);
            groupBoxMain.TabIndex = 0;
            groupBoxMain.TabStop = false;
            groupBoxMain.Text = "Программа расчёта комплексного сопротивления";
            groupBoxMain.Enter += groupBox1_Enter;
            // 
            // addElement
            // 
            addElement.Location = new Point(12, 310);
            addElement.Name = "addElement";
            addElement.Size = new Size(226, 39);
            addElement.TabIndex = 1;
            addElement.Text = "Добавить элемент";
            addElement.UseVisualStyleBackColor = true;
            // 
            // groupBoxElements
            // 
            groupBoxElements.Location = new Point(12, 39);
            groupBoxElements.Name = "groupBoxElements";
            groupBoxElements.Size = new Size(547, 195);
            groupBoxElements.TabIndex = 0;
            groupBoxElements.TabStop = false;
            groupBoxElements.Text = "Список элементов";
            // 
            // button1
            // 
            deletElement.Location = new Point(315, 310);
            deletElement.Name = "deletElement";
            deletElement.Size = new Size(226, 39);
            deletElement.TabIndex = 2;
            deletElement.Text = "Удалить элемент";
            deletElement.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(groupBoxMain);
            Name = "MainForm";
            Text = "Main Form";
            TransparencyKey = Color.White;
            Load += MainForm_Load;
            groupBoxMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain;
        private GroupBox groupBoxElements;
        private Button addElement;
        private Button deletElement;
    }
}