namespace Library_Mgt_Sys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void parrotSuperButton1_Click(object sender, EventArgs e) //Student Button
        {
            Student StudentInfo = new Student();
            StudentInfo.Show();
        }

        private void parrotSuperButton2_Click(object sender, EventArgs e) //Book Button
        {
            Bookcs BookcsInfo = new Bookcs();
            BookcsInfo.Show();
        }

        private void parrotSuperButton3_Click(object sender, EventArgs e) //Borrow
        {
            BorrowingA BorrowingInfo = new BorrowingA();
            BorrowingInfo.Show();
        }

        private void parrotSuperButton4_Click(object sender, EventArgs e) //Lib
        {
            LibrarianA LibrarianInfo = new LibrarianA();
            LibrarianInfo.Show();
        }
    }
}