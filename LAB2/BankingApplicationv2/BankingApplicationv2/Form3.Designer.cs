namespace BankingApplicationv2
{
    partial class Form3
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
            panel2 = new Panel();
            button2 = new Button();
            deetsButton = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            payButton = new Button();
            amtTextBox = new TextBox();
            benificiaryTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumPurple;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(deetsButton);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 361);
            panel2.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumPurple;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(0, 71);
            button2.Name = "button2";
            button2.Size = new Size(192, 71);
            button2.TabIndex = 1;
            button2.Text = "Transactions";
            button2.UseVisualStyleBackColor = false;
            // 
            // deetsButton
            // 
            deetsButton.BackColor = Color.MediumPurple;
            deetsButton.Dock = DockStyle.Top;
            deetsButton.FlatAppearance.BorderSize = 0;
            deetsButton.FlatStyle = FlatStyle.Flat;
            deetsButton.ForeColor = SystemColors.ButtonHighlight;
            deetsButton.Location = new Point(0, 0);
            deetsButton.Name = "deetsButton";
            deetsButton.Size = new Size(192, 71);
            deetsButton.TabIndex = 0;
            deetsButton.Text = "Details";
            deetsButton.UseVisualStyleBackColor = false;
            deetsButton.Click += deetsButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 89);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 19);
            label3.Name = "label3";
            label3.Size = new Size(196, 41);
            label3.TabIndex = 7;
            label3.Text = "Capital Bank";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(payButton);
            panel3.Controls.Add(amtTextBox);
            panel3.Controls.Add(benificiaryTextBox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(301, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 275);
            panel3.TabIndex = 5;
            // 
            // payButton
            // 
            payButton.BackColor = Color.MediumPurple;
            payButton.FlatAppearance.BorderSize = 0;
            payButton.FlatStyle = FlatStyle.Flat;
            payButton.ForeColor = SystemColors.ButtonHighlight;
            payButton.Location = new Point(139, 134);
            payButton.Name = "payButton";
            payButton.Size = new Size(143, 29);
            payButton.TabIndex = 6;
            payButton.Text = "Make Payment";
            payButton.UseVisualStyleBackColor = false;
            payButton.Click += payButton_Click;
            // 
            // amtTextBox
            // 
            amtTextBox.Location = new Point(183, 62);
            amtTextBox.Name = "amtTextBox";
            amtTextBox.Size = new Size(178, 27);
            amtTextBox.TabIndex = 5;
            // 
            // benificiaryTextBox
            // 
            benificiaryTextBox.Location = new Point(183, 24);
            benificiaryTextBox.Name = "benificiaryTextBox";
            benificiaryTextBox.Size = new Size(178, 27);
            benificiaryTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 69);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 31);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Benificiary";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button2;
        private Button deetsButton;
        private Panel panel1;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Button payButton;
        private TextBox amtTextBox;
        private TextBox benificiaryTextBox;
    }
}