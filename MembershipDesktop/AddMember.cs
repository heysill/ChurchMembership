using Membership_BL;

namespace MembershipDesktop
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string age = txt_age.Text.Trim();
            string birthdate = txt_birthdate.Text.Trim();
            string address = txt_address.Text.Trim();
            string gmail = txt_gmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(age))
            {
                MessageBox.Show("Name and Age are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BusinessLogic businessLogic = new BusinessLogic();
            businessLogic.AddMember(name, age, birthdate, address, gmail);
            MessageBox.Show("Successfully Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_name.Clear();
            txt_age.Clear();
            txt_birthdate.Clear();
            txt_address.Clear();
            txt_gmail.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        }
    }


