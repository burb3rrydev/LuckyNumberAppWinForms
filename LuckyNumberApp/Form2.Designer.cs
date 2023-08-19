namespace LuckyNumberApp
{
    partial class Form2
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
            labelLuckyNumber = new Label();
            SuspendLayout();
            // 
            // labelLuckyNumber
            // 
            labelLuckyNumber.AutoSize = true;
            labelLuckyNumber.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelLuckyNumber.ForeColor = SystemColors.Window;
            labelLuckyNumber.Location = new Point(53, 75);
            labelLuckyNumber.Name = "labelLuckyNumber";
            labelLuckyNumber.Size = new Size(59, 25);
            labelLuckyNumber.TabIndex = 0;
            labelLuckyNumber.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(282, 200);
            Controls.Add(labelLuckyNumber);
            Name = "Form2";
            Text = "Lucky Number Result";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLuckyNumber;
    }
}