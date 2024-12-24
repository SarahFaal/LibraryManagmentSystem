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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox3.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                GlobalData.books.Add(new Book(textBox1.Text, textBox3.Text, textBox2.Text));
                label6.Text = "کتاب شما با موفقیت اضافه شد!";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Book book in GlobalData.books)
            {
                if (book.Title == textBox5.Text || book.ISBN == textBox6.Text)
                {
                    GlobalData.books.Remove(book);
                    label10.Text = "کتاب شما با موفقیت حذف شد!";
                }
                else
                {
                    label10.Text = "کتابی با این مشخصات وجود ندارد!";
                }
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
