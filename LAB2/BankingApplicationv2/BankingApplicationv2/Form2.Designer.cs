namespace BankingApplicationv2
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
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            transButton = new Button();
            button1 = new Button();
            panel3 = new Panel();
            transLabel = new Label();
            lastAccessLabel = new Label();
            balanceLabel = new Label();
            nameLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.TabIndex = 1;
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
            // panel2
            // 
            panel2.BackColor = Color.MediumPurple;
            panel2.Controls.Add(transButton);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 361);
            panel2.TabIndex = 2;
            // 
            // transButton
            // 
            transButton.BackColor = Color.MediumPurple;
            transButton.Dock = DockStyle.Top;
            transButton.FlatAppearance.BorderSize = 0;
            transButton.FlatStyle = FlatStyle.Flat;
            transButton.ForeColor = SystemColors.ButtonHighlight;
            transButton.Location = new Point(0, 71);
            transButton.Name = "transButton";
            transButton.Size = new Size(192, 71);
            transButton.TabIndex = 1;
            transButton.Text = "Transactions";
            transButton.UseVisualStyleBackColor = false;
            transButton.Click += transButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(192, 71);
            button1.TabIndex = 0;
            button1.Text = "Details";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(transLabel);
            panel3.Controls.Add(lastAccessLabel);
            panel3.Controls.Add(balanceLabel);
            panel3.Controls.Add(nameLabel);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(287, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 275);
            panel3.TabIndex = 3;
            // 
            // transLabel
            // 
            transLabel.AutoSize = true;
            transLabel.Location = new Point(228, 141);
            transLabel.Name = "transLabel";
            transLabel.Size = new Size(90, 20);
            transLabel.TabIndex = 9;
            transLabel.Text = "PlaceHolder";
            // 
            // lastAccessLabel
            // 
            lastAccessLabel.AutoSize = true;
            lastAccessLabel.Location = new Point(228, 106);
            lastAccessLabel.Name = "lastAccessLabel";
            lastAccessLabel.Size = new Size(90, 20);
            lastAccessLabel.TabIndex = 8;
            lastAccessLabel.Text = "PlaceHolder";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(228, 69);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(90, 20);
            balanceLabel.TabIndex = 7;
            balanceLabel.Text = "PlaceHolder";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(228, 31);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(90, 20);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "PlaceHolder";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 141);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 5;
            label5.Text = "Past Transactions";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 106);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 4;
            label4.Text = "Last Accessed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 69);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "Balance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 31);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Button transButton;
        private Button button1;
        private Panel panel3;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label transLabel;
        private Label lastAccessLabel;
        private Label balanceLabel;
        private Label nameLabel;
    }
}