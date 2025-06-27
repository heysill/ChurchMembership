using Membership_BL;
using MembershipCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembershipDesktop
{
    public partial class UpdateMember : Form
    {

        private Member originalMember;
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            BusinessLogic businessLogic = new BusinessLogic();

            string oldName = txt_update.Text.Trim();

            if (string.IsNullOrWhiteSpace(oldName))
            {
                MessageBox.Show("Please enter the member name to update.");
                return;
            }

            var member = businessLogic.GetMember(oldName);

            if (member == null)
            {
                MessageBox.Show("Member not found.");
                return;
            }

            originalMember = member;

            txt_name.Text = member.Name.Trim();
            txt_age.Text = member.Age.Trim();
            txt_birthdate.Text = member.Birthdate.Trim();
            txt_address.Text = member.Address.Trim();
            txt_gmail.Text = member.Gmail.Trim();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (originalMember == null)
            {
                MessageBox.Show("No member loaded to update.");
                return;
            }

            BusinessLogic businessLogic = new BusinessLogic();

            string newName = string.IsNullOrWhiteSpace(txt_name.Text) ? originalMember.Name : txt_name.Text.Trim();
            string newAge = string.IsNullOrWhiteSpace(txt_age.Text) ? originalMember.Age : txt_age.Text.Trim();
            string newBirthdate = string.IsNullOrWhiteSpace(txt_birthdate.Text) ? originalMember.Birthdate : txt_birthdate.Text.Trim();
            string newAddress = string.IsNullOrWhiteSpace(txt_address.Text) ? originalMember.Address : txt_address.Text.Trim();
            string newGmail = string.IsNullOrWhiteSpace(txt_gmail.Text) ? originalMember.Gmail : txt_gmail.Text.Trim();

            var updatedMember = new Member
            {
                Name = newName,
                Age = newAge,
                Birthdate = newBirthdate,
                Address = newAddress,
                Gmail = newGmail
            };

            bool updated = businessLogic.UpdateMember(originalMember.Name, updatedMember);

            if (updated)
            {
                MessageBox.Show("Member successfully updated.");

                txt_update.Clear();
                txt_name.Clear();
                txt_age.Clear();
                txt_birthdate.Clear();
                txt_address.Clear();
                txt_gmail.Clear();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }

            originalMember = null;
        }
    }
}
