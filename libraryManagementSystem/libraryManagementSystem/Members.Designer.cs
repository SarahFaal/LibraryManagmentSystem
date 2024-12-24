namespace libraryManagementSystem
{
    partial class Members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            newMember = new GroupBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            newMember.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 31);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "ثبت نام اعضا";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 73);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "ممبر آیدی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 116);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 2;
            label3.Text = "نام و نام خانوادگی";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(58, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 27);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(58, 171);
            button1.Name = "button1";
            button1.Size = new Size(334, 50);
            button1.TabIndex = 5;
            button1.Text = "ثبت اطلاعات";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(691, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "همه اعضا";
            // 
            // button2
            // 
            button2.Location = new Point(773, 26);
            button2.Name = "button2";
            button2.Size = new Size(91, 53);
            button2.TabIndex = 8;
            button2.Text = "نمایش";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(4, 34);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.RightToLeft = RightToLeft.No;
            textBox4.Size = new Size(759, 87);
            textBox4.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(916, 569);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // newMember
            // 
            newMember.Controls.Add(label6);
            newMember.Controls.Add(button1);
            newMember.Controls.Add(textBox2);
            newMember.Controls.Add(textBox1);
            newMember.Controls.Add(label3);
            newMember.Controls.Add(label2);
            newMember.Controls.Add(label1);
            newMember.Location = new Point(453, 49);
            newMember.Name = "newMember";
            newMember.Size = new Size(425, 266);
            newMember.TabIndex = 12;
            newMember.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 234);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(0, 20);
            label6.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(8, 369);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(870, 139);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 562);
            Controls.Add(groupBox2);
            Controls.Add(newMember);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Members";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Members";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            newMember.ResumeLayout(false);
            newMember.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private Button button2;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private GroupBox newMember;
        private GroupBox groupBox2;
        private Label label6;
    }
}