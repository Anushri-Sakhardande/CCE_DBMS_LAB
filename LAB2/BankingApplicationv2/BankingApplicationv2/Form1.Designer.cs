namespace BankingApplicationv2
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
            panel1 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            forgotTextBox = new TextBox();
            passTextBox = new TextBox();
            nameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 89);
            panel1.TabIndex = 0;
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
            panel3.Controls.Add(forgotTextBox);
            panel3.Controls.Add(passTextBox);
            panel3.Controls.Add(nameTextBox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(193, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(372, 248);
            panel3.TabIndex = 2;
            // 
            // forgotTextBox
            // 
            forgotTextBox.Location = new Point(82, 194);
            forgotTextBox.Name = "forgotTextBox";
            forgotTextBox.PasswordChar = '*';
            forgotTextBox.Size = new Size(188, 27);
            forgotTextBox.TabIndex = 6;
            forgotTextBox.Visible = false;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(152, 71);
            passTextBox.Name = "passTextBox";
            passTextBox.PasswordChar = '*';
            passTextBox.Size = new Size(185, 27);
            passTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(152, 28);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(184, 27);
            nameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 78);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 31);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // button2
            // 
            button2.BackColor = Color.MediumPurple;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(106, 159);
            button2.Name = "button2";
            button2.Size = new Size(144, 29);
            button2.TabIndex = 1;
            button2.Text = "Forgot Password";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(106, 124);
            button1.Name = "button1";
            button1.Size = new Size(144, 29);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox passTextBox;
        private TextBox nameTextBox;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label3;
        private TextBox forgotTextBox;
    }
}
