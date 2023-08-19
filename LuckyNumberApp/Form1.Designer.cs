namespace LuckyNumberApp
{
    partial class Form1
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
            labelMinRange = new Label();
            labelMaxRange = new Label();
            textBoxMinRange = new TextBox();
            textBoxMaxRange = new TextBox();
            comboBoxMethods = new ComboBox();
            tnShowLuckyNumber = new Button();
            label1 = new Label();
            lblCalculation = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelMinRange
            // 
            labelMinRange.AutoSize = true;
            labelMinRange.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelMinRange.ForeColor = SystemColors.Window;
            labelMinRange.Location = new Point(85, 111);
            labelMinRange.Name = "labelMinRange";
            labelMinRange.Size = new Size(169, 25);
            labelMinRange.TabIndex = 0;
            labelMinRange.Text = "Minimum of Range:";
            // 
            // labelMaxRange
            // 
            labelMaxRange.AutoSize = true;
            labelMaxRange.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelMaxRange.ForeColor = SystemColors.Window;
            labelMaxRange.Location = new Point(85, 164);
            labelMaxRange.Name = "labelMaxRange";
            labelMaxRange.Size = new Size(172, 25);
            labelMaxRange.TabIndex = 1;
            labelMaxRange.Text = "Maximum of Range:";
            // 
            // textBoxMinRange
            // 
            textBoxMinRange.Location = new Point(269, 114);
            textBoxMinRange.Name = "textBoxMinRange";
            textBoxMinRange.Size = new Size(102, 23);
            textBoxMinRange.TabIndex = 2;
            // 
            // textBoxMaxRange
            // 
            textBoxMaxRange.Location = new Point(269, 167);
            textBoxMaxRange.Name = "textBoxMaxRange";
            textBoxMaxRange.Size = new Size(100, 23);
            textBoxMaxRange.TabIndex = 3;
            // 
            // comboBoxMethods
            // 
            comboBoxMethods.FormattingEnabled = true;
            comboBoxMethods.Location = new Point(94, 62);
            comboBoxMethods.Name = "comboBoxMethods";
            comboBoxMethods.Size = new Size(277, 23);
            comboBoxMethods.TabIndex = 4;
            comboBoxMethods.Text = "Choose Method";
            // 
            // tnShowLuckyNumber
            // 
            tnShowLuckyNumber.BackColor = SystemColors.ButtonHighlight;
            tnShowLuckyNumber.FlatStyle = FlatStyle.Flat;
            tnShowLuckyNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tnShowLuckyNumber.Location = new Point(136, 314);
            tnShowLuckyNumber.Name = "tnShowLuckyNumber";
            tnShowLuckyNumber.Size = new Size(186, 32);
            tnShowLuckyNumber.TabIndex = 5;
            tnShowLuckyNumber.Text = "Get Lucky Number";
            tnShowLuckyNumber.UseVisualStyleBackColor = false;
            tnShowLuckyNumber.Click += btnShowLuckyNumber_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(122, 18);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 6;
            label1.Text = "Enter A Range Of Numbers";
            // 
            // lblCalculation
            // 
            lblCalculation.AutoSize = true;
            lblCalculation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalculation.ForeColor = SystemColors.Window;
            lblCalculation.Location = new Point(3, 0);
            lblCalculation.Name = "lblCalculation";
            lblCalculation.Size = new Size(45, 19);
            lblCalculation.TabIndex = 7;
            lblCalculation.Text = "label2";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblCalculation, 0, 0);
            tableLayoutPanel1.Location = new Point(85, 216);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(284, 80);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(458, 358);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(tnShowLuckyNumber);
            Controls.Add(comboBoxMethods);
            Controls.Add(textBoxMaxRange);
            Controls.Add(textBoxMinRange);
            Controls.Add(labelMaxRange);
            Controls.Add(labelMinRange);
            Name = "Form1";
            Text = "Lucky Number Calculator";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMinRange;
        private Label labelMaxRange;
        private TextBox textBoxMinRange;
        private TextBox textBoxMaxRange;
        private ComboBox comboBoxMethods;
        private Button tnShowLuckyNumber;
        private Label label1;
        private Label lblCalculation;
        private TableLayoutPanel tableLayoutPanel1;
    }
}