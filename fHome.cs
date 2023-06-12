using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROFILE_MANAGEMENT
{
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            fSearch fSearch = new fSearch();
            this.Hide();
            fSearch.ShowDialog();
            this.Show();
        }

        private void btnexxit_Click(object sender, EventArgs e)
        {
            DialogResult warning;
            warning = MessageBox.Show("Profiles Management Program Will Perform Exit !", "NOTIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (warning == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
    }
}
