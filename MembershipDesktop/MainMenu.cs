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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddMember addForm = new AddMember();
            addForm.ShowDialog();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            ViewMember viewMember = new ViewMember();
            viewMember.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            CancelMember cancelMember = new CancelMember();
            cancelMember.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateMember updateMember = new UpdateMember();
            updateMember.ShowDialog();
        }
    }
}
