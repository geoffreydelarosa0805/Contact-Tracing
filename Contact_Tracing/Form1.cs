namespace Contact_Tracing
{
    public partial class Form_JowaApplicationForm : Form
    {
        public Form_JowaApplicationForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\HP\Documents\Outputs\Jowa Application Form.text");
            file.WriteLine("First Name : " + textBox_FirstName.Text);
            file.WriteLine("Surname : " + textBox_Surname.Text);
            file.WriteLine("Gender : " + textBox_Gender.Text);
            file.WriteLine("Birthdate : " + textBox_Birthdate.Text);
            file.WriteLine("Age : " + textBox_Age.Text);
            file.WriteLine("Address : " + textBox_Address.Text);
            file.WriteLine("Height : " + textBox_Height.Text);
            file.WriteLine("Weight : " + textBox_Weight.Text);
            file.WriteLine("Status : " + textBox_Status.Text);
           

            file.Close();
        }

    }
}