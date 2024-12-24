namespace libraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            members.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Baarrow baarrow = new Baarrow();
            baarrow.ShowDialog();
        }
    }
}
