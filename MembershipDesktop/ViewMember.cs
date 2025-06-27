using Membership_BL;

namespace MembershipDesktop
{
    public partial class ViewMember : Form
    {
        public ViewMember()
        {
            InitializeComponent();
            Load += ViewMember_Load;
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {

            BusinessLogic businessLogic = new BusinessLogic();

            var members = businessLogic.GetAllMembers();

            dataGridView1.AutoGenerateColumns = false;
            column_name.DataPropertyName = "Name";
            column_age.DataPropertyName = "Age";
            column_birthdate.DataPropertyName = "Birthdate";
            column_address.DataPropertyName = "Address";
            column_gmail.DataPropertyName = "Gmail";

            dataGridView1.DataSource = members;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
