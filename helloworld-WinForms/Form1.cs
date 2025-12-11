namespace helloworld_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hello_Click(object sender, EventArgs e)
        {
            textBoxShowHello.Text = "Hello,World";
        }

        private void hello_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxShowHello.Text = null;
        }
    }
}
