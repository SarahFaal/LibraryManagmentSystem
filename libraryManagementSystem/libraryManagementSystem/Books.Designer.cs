namespace libraryManagementSystem
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label10 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(566, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(566, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(566, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(566, 283);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.RightToLeft = RightToLeft.Yes;
            textBox4.Size = new Size(241, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "موجود";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(689, 146);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 4;
            label1.Text = "اضافه کردن کتاب";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(831, 187);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(48, 20);
            label2.TabIndex = 5;
            label2.Text = "ISBN :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(831, 217);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "نام کتاب :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(831, 250);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "نویسنده :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(831, 283);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(67, 20);
            label5.TabIndex = 8;
            label5.Text = "وضعیت :";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(566, 336);
            button1.Name = "button1";
            button1.Size = new Size(241, 29);
            button1.TabIndex = 9;
            button1.Text = "ثبت اطلاعات";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(581, 383);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(0, 20);
            label6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(302, 217);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(69, 20);
            label7.TabIndex = 15;
            label7.Text = "نام کتاب :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(302, 187);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(48, 20);
            label8.TabIndex = 14;
            label8.Text = "ISBN :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(160, 146);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 13;
            label9.Text = "حذف کردن کتاب";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(37, 217);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(241, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(37, 184);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(241, 27);
            textBox6.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(52, 297);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(0, 20);
            label10.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(37, 250);
            button2.Name = "button2";
            button2.Size = new Size(241, 29);
            button2.TabIndex = 16;
            button2.Text = "درخواست حذف";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(917, 565);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 562);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "کتاب ها";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label10;
        private Button button2;
        private PictureBox pictureBox1;
    }
}