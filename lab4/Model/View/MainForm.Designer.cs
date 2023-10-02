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
        /// <param name="disposing">true if managed resources should
        /// be disposed; otherwise, false.</param>
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            deletElement = new Button();
            addElement = new Button();
            groupBoxElements = new GroupBox();
            buttonDeleteElements = new Button();
            dataGridView1 = new DataGridView();
            buttonReset = new Button();
            buttonFilterElement = new Button();
            toolStrip1 = new ToolStrip();
            File = new ToolStripDropDownButton();
            OpenFile = new ToolStripMenuItem();
            SaveFile = new ToolStripMenuItem();
            groupBoxElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // deletElement
            // 
            deletElement.Location = new Point(16, 250);
            deletElement.Margin = new Padding(3, 2, 3, 2);
            deletElement.Name = "deletElement";
            deletElement.Size = new Size(225, 29);
            deletElement.TabIndex = 5;
            deletElement.Text = "Удалить элемент";
            deletElement.UseVisualStyleBackColor = true;
            deletElement.Click += DeletElement_Click;
            // 
            // addElement
            // 
            addElement.Location = new Point(16, 215);
            addElement.Margin = new Padding(3, 2, 3, 2);
            addElement.Name = "addElement";
            addElement.Size = new Size(225, 29);
            addElement.TabIndex = 4;
            addElement.Text = "Добавить элемент";
            addElement.UseVisualStyleBackColor = true;
            addElement.Click += AddElement_Click;
            // 
            // groupBoxElements
            // 
            groupBoxElements.Controls.Add(buttonDeleteElements);
            groupBoxElements.Controls.Add(addElement);
            groupBoxElements.Controls.Add(dataGridView1);
            groupBoxElements.Controls.Add(buttonReset);
            groupBoxElements.Controls.Add(buttonFilterElement);
            groupBoxElements.Controls.Add(deletElement);
            groupBoxElements.Location = new Point(10, 31);
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
            buttonDeleteElements.Location = new Point(247, 215);
            buttonDeleteElements.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteElements.Name = "buttonDeleteElements";
            buttonDeleteElements.Size = new Size(252, 29);
            buttonDeleteElements.TabIndex = 8;
            buttonDeleteElements.Text = "Удалить список элементов";
            buttonDeleteElements.UseVisualStyleBackColor = true;
            buttonDeleteElements.Click += ButtonDeleteElements_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Location = new Point(15, 20);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(484, 190);
            dataGridView1.TabIndex = 0;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(376, 251);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(123, 29);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += ButtonReset_Click;
            // 
            // buttonFilterElement
            // 
            buttonFilterElement.Location = new Point(247, 251);
            buttonFilterElement.Margin = new Padding(3, 2, 3, 2);
            buttonFilterElement.Name = "buttonFilterElement";
            buttonFilterElement.Size = new Size(123, 28);
            buttonFilterElement.TabIndex = 6;
            buttonFilterElement.Text = "Фильтр";
            buttonFilterElement.UseVisualStyleBackColor = true;
            buttonFilterElement.Click += ButtonFilterElement_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { File });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(540, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // File
            // 
            File.DisplayStyle = ToolStripItemDisplayStyle.Text;
            File.DropDownItems.AddRange(new ToolStripItem[] { OpenFile, SaveFile });
            File.Image = (Image)resources.GetObject("File.Image");
            File.ImageTransparentColor = Color.Magenta;
            File.Name = "File";
            File.Size = new Size(49, 22);
            File.Text = "Файл";
            // 
            // OpenFile
            // 
            OpenFile.Name = "OpenFile";
            OpenFile.Size = new Size(164, 22);
            OpenFile.Text = "Открыть файл";
            OpenFile.Click += OpenFile_Click;
            // 
            // SaveFile
            // 
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new Size(164, 22);
            SaveFile.Text = "Сохранить файл";
            SaveFile.Click += SaveFile_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 321);
            Controls.Add(toolStrip1);
            Controls.Add(groupBoxElements);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Программа расчёта комплексного сопротивлениия";
            TransparencyKey = Color.White;
            Load += MainForm_Load;
            groupBoxElements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deletElement;
        private Button addElement;
        private GroupBox groupBoxElements;
        private Button buttonFilterElement;
        private Button buttonReset;
        private DataGridView dataGridView1;
        private Button buttonDeleteElements;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton File;
        private ToolStripMenuItem OpenFile;
        private ToolStripMenuItem SaveFile;
    }
}