namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\HP\Documents\Outputs\Jowa Application Form.text");
            file.WriteLine("Pogi Ako");
            file.Close();
        }

    }
}