namespace Uygulama_1
{
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGit_click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }
    }
}