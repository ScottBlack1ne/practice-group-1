using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace practice_group
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == null)
            {
                MessageBox.Show("Username field is empty");
            }

            if (txtPassword.Text == null)
            {
                MessageBox.Show("Password field is empty");
            }
        }
    }
}
