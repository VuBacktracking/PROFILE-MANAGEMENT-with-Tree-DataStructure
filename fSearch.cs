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
    public partial class fSearch : Form
    {
        public static fSearch fSearchInstance;
        public DataGridView dataadd;
        public fSearch()
        {
            InitializeComponent();
            fSearchInstance = this;
            dataadd = dataGridView1;
        }
        public void PrintData(ListContact contact, DataTable data)
        {
            for (int i = 0; i < contact.Count_Contact; i++)
            {
                DataRow row = data.NewRow();
                Contact line = contact.listContact[i];
                string[] words;
                words = line.ToString().Split(',');
                row["ID"] = words[0];
                row["Name"] = words[1];
                row["Contact Number"] = words[2];
                row["Date"] = words[3];
                data.Rows.Add(row);
                dataGridView1.DataSource = data;
            }
        }

        private void fSearch_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Name");
            data.Columns.Add("Contact Number");
            data.Columns.Add("Date");
            dataGridView1.DataSource = data;
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Name");
            data.Columns.Add("Contact Number");
            data.Columns.Add("Date");
            ListContact contact = new ListContact();
            contact.GetContact("contact.csv");
            PrintData(contact, data);
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

        private void btnnamesearch_Click(object sender, EventArgs e)
        {
            string name = tbname.Text;
            BinarySearchTree bst = new BinarySearchTree();
            bst.GetContactTree("contact.csv");
            ListContact contact = bst.FindByName(name);
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Name");
            data.Columns.Add("Contact Number");
            data.Columns.Add("Date");

            if (contact.Count_Contact > 0)
                PrintData(contact, data);
            else MessageBox.Show("You Have Entered An Invalid Name!");
        }

        private void btndatesearch_Click(object sender, EventArgs e)
        {
            string from = dtpfrom.Value.ToString("dd/MM/yyyy");
            string to = dtpto.Value.ToString("dd/MM/yyyy");
            BinarySearchTree bst = new BinarySearchTree();
            bst.GetContactTree("contact.csv");
            ListContact contact = bst.FindContactBetweenDate(from, to);
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Name");
            data.Columns.Add("Contact number");
            data.Columns.Add("Date");

            if (contact.Count_Contact > 0)
                PrintData(contact, data);
            else MessageBox.Show("You Have Entered An Invalid Date!");
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            fSetting fSetting = new fSetting();
            this.Hide();
            fSetting.ShowDialog();
            this.Show();
        }
    }
}
