namespace SOFTENG
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._301881021_190283413369437_1700894856131726275_n;
            pictureBox1.Location = new Point(368, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 262);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(351, 720);
            button1.Name = "button1";
            button1.Size = new Size(303, 67);
            button1.TabIndex = 7;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 358);
            label1.Name = "label1";
            label1.Size = new Size(151, 38);
            label1.TabIndex = 8;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(110, 425);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(114, 493);
            label3.Name = "label3";
            label3.Size = new Size(94, 38);
            label3.TabIndex = 10;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(114, 563);
            label4.Name = "label4";
            label4.Size = new Size(132, 38);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 635);
            label5.Name = "label5";
            label5.Size = new Size(239, 38);
            label5.TabIndex = 12;
            label5.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 348);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(455, 48);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 553);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(455, 48);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(293, 483);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(455, 48);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(293, 415);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(455, 48);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(293, 625);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(455, 48);
            textBox5.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(803, 720);
            button2.Name = "button2";
            button2.Size = new Size(96, 67);
            button2.TabIndex = 18;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(713, 735);
            label6.Name = "label6";
            label6.Size = new Size(48, 38);
            label6.TabIndex = 19;
            label6.Text = "Or";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 822);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        public Button button2;
        private Label label6;
    }
}