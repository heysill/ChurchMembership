using Membership_BL;

namespace MembershipDesktop
{
    public partial class CancelMember : Form
    {
        public CancelMember()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            BusinessLogic businessLogic = new BusinessLogic();

            var members = businessLogic.GetAllMembers();

            if (members.Count == 0)
            {
                MessageBox.Show("No members found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string name = txt_cancel.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a member name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool removed = businessLogic.CancelMember(name);

            if (removed)
            {
                MessageBox.Show("Membership Cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_cancel.Clear();
            }
            else
            {
                MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
