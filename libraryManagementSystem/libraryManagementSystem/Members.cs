using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 2)
            {
                GlobalData.members.Add(new Member(textBox1.Text, textBox2.Text));
                label6.Text = "کاربر جدید با موفقیت اضافه شد!";
                label6.ForeColor = Color.Green;
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                label6.Text = "خطا";
                label6.ForeColor = Color.Red;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Member item in GlobalData.members)
            {

                textBox4.Text += "/ Id: " + item.MemberId + " , Name: " + item.Name + " , BarrowedBooks: ";
                foreach (Book item1 in item.BorrowedBooks)
                {
                    textBox4.Text += item1.Title + ", ";
                }

                textBox4.Text += "  --  ";

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
