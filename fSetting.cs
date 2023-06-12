using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROFILE_MANAGEMENT
{
    public partial class fSetting : Form
    {
        public fSetting()
        {
            InitializeComponent();
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
                fSearch.fSearchInstance.dataadd.DataSource = data;
                dataGridView1.DataSource = data;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            BinarySearchTree bst = new BinarySearchTree();
            ListContact contact = new ListContact();
            string id = tbid.Text;
            string name = tbname.Text;
            string number = tbctnumber.Text;
            string date = dtpdate.Value.ToString("dd/MM/yyyy");
            bool check = true;
            string line;
            string[] words;
            StreamReader infile = File.OpenText("contact.csv");
            string line0 = infile.ReadLine();
            while (infile.Peek() != -1)
            {
                line = infile.ReadLine();
                if (line.Equals(line0))
                    continue;
                words = line.Split(',');
                if (id == words[0] || id == "") check = false;
            }
            infile.Close();
            contact.GetContact("contact.csv");
            bst.GetContactTree("contact.csv");
            if (check == true)
            {
                Contact delete = new Contact(id, name, number, date);
                bst.Insert(delete);
                contact.AddContact(delete);
                MessageBox.Show("File added successesfully!");
            }
            else MessageBox.Show("You have entered an invalid file ID!");
            File.Delete("contact.csv");
            File.AppendAllText("contact.csv", "ID,Full_Name,Contact_Number,Date");
            for (int i = 0; i < contact.Count_Contact; i++)
            {
                File.AppendAllText("contact.csv", "\n" + contact.listContact[i].ToString());
            }
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Name");
            data.Columns.Add("Contact Number");
            data.Columns.Add("Date");
            PrintData(contact, data);
        }

        private void btnexxit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            BinarySearchTree bst = new BinarySearchTree();
            ListContact contact = new ListContact();

            string id = tbid.Text;
            string name = tbname.Text;
            string number = tbctnumber.Text;
            string date = dtpdate.Value.ToString("dd/MM/yyyy");

            int count = 0;
            string line;
            string[] words;
            StreamReader infile = File.OpenText("contact.csv");
            string line0 = infile.ReadLine();
            while (infile.Peek() != -1)
            {
                line = infile.ReadLine();
                if (line.Equals(line0))
                    continue;
                words = line.Split(',');
                Contact delete = new Contact(words[0], words[1], words[2], words[3]);
                contact.AddContact(delete);
                bst.Insert(delete);
                if (id == words[0])
                {
                    bst.Remove(delete);
                    contact.RemoveContact(delete);
                    count = 1;
                }
            }
            infile.Close();

            if (count == 1)
            {
                MessageBox.Show("File deleted successesfully!");
            }
            else MessageBox.Show("You have entered an invalid file ID!");
            File.Delete("contact.csv");
            File.AppendAllText("contact.csv", "ID,Full_Name,Contact_Number,Date");
            for (int i = 0; i < contact.Count_Contact; i++)
            {
                File.AppendAllText("contact.csv", "\n" + contact.listContact[i].ToString());
            }
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Name");
            data.Columns.Add("Contact Number");
            data.Columns.Add("Date");
            PrintData(contact, data);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            BinarySearchTree bst = new BinarySearchTree();
            ListContact contact = new ListContact();

            string id = tbid.Text;
            string name = tbname.Text;
            string number = tbctnumber.Text;
            string date = dtpdate.Value.ToString("dd/MM/yyyy");

            int count = 0;
            string line;
            string[] words;
            StreamReader infile = File.OpenText("contact.csv");
            string line0 = infile.ReadLine();
            while (infile.Peek() != -1)
            {
                line = infile.ReadLine();
                if (line.Equals(line0))
                    continue;
                words = line.Split(',');
                Contact update = new Contact(id, name, number, date);
                Contact delete = new Contact(words[0], words[1], words[2], words[3]);
                contact.AddContact(delete);
                bst.Insert(delete);
                if (id == words[0])
                {
                    bst.Remove(delete);
                    contact.RemoveContact(delete);
                    contact.AddContact(update);
                    bst.Insert(update);
                    count = 1;
                }
            }
            infile.Close();

            if (count == 1)
            {
                MessageBox.Show("File updated successesfully!");
            }
            else MessageBox.Show("You have entered an invalid file ID!");
            File.Delete("contact.csv");
            File.AppendAllText("contact.csv", "ID,Full_Name,Contact_Number,Date");
            for (int i = 0; i < contact.Count_Contact; i++)
            {
                File.AppendAllText("contact.csv", "\n" + contact.listContact[i].ToString());
            }
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Name");
            data.Columns.Add("Contact Number");
            data.Columns.Add("Date");
            PrintData(contact, data);
        }

        private void fSetting_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Name");
            data.Columns.Add("Contact number");
            data.Columns.Add("Date");
            ListContact contact = new ListContact();
            contact.GetContact("contact.csv");
            PrintData(contact, data);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = new DataGridViewRow();
            row1 = dataGridView1.Rows[e.RowIndex];
            tbid.Text = Convert.ToString(row1.Cells["ID"].Value);
            tbname.Text = Convert.ToString(row1.Cells["Name"].Value);
            tbctnumber.Text = Convert.ToString(row1.Cells["Contact Number"].Value);
        }
    }
}
