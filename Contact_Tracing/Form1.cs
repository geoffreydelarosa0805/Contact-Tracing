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
            StreamWriter file = new StreamWriter(@"C:\Users\HP\Documents\Outputs\Contact Tracing File\" + textBox_Surname.Text + "-" + textBox_FirstName.Text + ".txt");

            file.WriteLine("Date of Filling : " + dateTimePicker_DateofFilling.Text);
            file.WriteLine("First Name : " + textBox_FirstName.Text);
            file.WriteLine("Surname : " + textBox_Surname.Text);
            file.WriteLine("Gender : " + textBox_Gender.Text);
            file.WriteLine("Birthdate : " + textBox_Birthdate.Text);
            file.WriteLine("Age : " + textBox_Age.Text);
            file.WriteLine("Address : " + textBox_Address.Text);
            file.WriteLine("Email : " + textBox_Email.Text);
            file.WriteLine("Phone No. : " + textBox_PhoneNo.Text);
            file.WriteLine("Telephone : " + textBox_Telephone.Text);
            file.WriteLine("");
            file.WriteLine("Other Person to Contact");
            file.WriteLine("Person's Name : " + textBox_PersonName.Text);
            file.WriteLine("Relationship : " + textBox_Relationship.Text);
            file.WriteLine("Email Address : " + textBox_EmailAddress.Text);
            file.WriteLine("Contact No. : " + textBox_ContactNo.Text);
            file.WriteLine("Person's Address : " + textBox_PersonAddress.Text);
            file.WriteLine("Occupation : " + textBox_Occupation.Text);
            file.WriteLine("Workplace Address : " + textBox_WorkplaceAddress.Text);


            file.Close();

            MessageBox.Show("Your information is submitted successfully!");

            StreamReader read = new StreamReader(@"C:\Users\HP\Documents\Outputs\Contact Tracing File\" + textBox_Surname.Text + "-" + textBox_FirstName.Text + ".txt");

            ListViewItem item;
            item = listView_ContactsOfUsers.Items.Add(textBox_Surname.Text + ", " + textBox_FirstName.Text);
            item.SubItems.Add(dateTimePicker_DateofFilling.Text);

            

            listView_ContactsOfUsers.Text = read.ReadToEnd();


            read.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }

}