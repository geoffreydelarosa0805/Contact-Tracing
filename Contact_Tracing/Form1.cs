namespace Contact_Tracing
{
    public partial class Form_ContactTracingForm : Form
    {
        public Form_ContactTracingForm()
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
            file.WriteLine("Email : " + textBox_Email.Text);
            file.WriteLine("Phone No. : " + textBox_PhoneNo.Text);
            file.WriteLine("Telephone : " + textBox_Telephone.Text);
            file.WriteLine("Person's Name : " + textBox_PersonName.Text);
            file.WriteLine("Relationship : " + textBox_Relationship.Text);
            file.WriteLine("Email Address : " + textBox_EmailAddress.Text);
            file.WriteLine("Contact No. : " + textBox_ContactNo.Text);
            file.WriteLine("Person's Address : " + textBox_PersonAddress.Text);
            file.WriteLine("Occupation : " + textBox_Occupation.Text);
            file.WriteLine("Workplace Address : " + textBox_WorkplaceAddress.Text);

            file.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}