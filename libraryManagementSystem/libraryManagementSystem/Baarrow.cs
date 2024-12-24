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
    public partial class Baarrow : Form
    {
        public Baarrow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Book item in GlobalData.books)
            {
                if (item.Title == textBox1.Text || item.ISBN == textBox1.Text)
                {
                    Book book = item;
                    foreach (Member item2 in GlobalData.members)
                    {
                        if (item2.MemberId == textBox2.Text)
                        {
                            Member member = item2;
                            member.BorrowBook(book);
                            label6.Text = "با موفقیت ثبت شد!";
                            label6.ForeColor = Color.Green;
                        }
                        
                    }
                }
                else
                {
                    label6.Text = "خطا!";
                    label6.ForeColor = Color.Red;
                }
            }









        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Book item in GlobalData.books)
            {
                if (item.Title == textBox4.Text || item.ISBN == textBox4.Text)
                {
                    Book book = item;
                    foreach (Member item2 in GlobalData.members)
                    {
                        if (item2.MemberId == textBox3.Text)
                        {
                            Member member = item2;
                            member.ReturnBook(book);
                            label7.Text = "با موفقیت ثبت شد!";
                            label7.ForeColor = Color.Green;
                        }
                        

                    }
                }
                else
                {
                    label7.Text = "خطا!";
                    label7.ForeColor = Color.Red;
                }
            }
        }
    }
}
