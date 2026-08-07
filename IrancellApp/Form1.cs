using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace IrancellApp
{
    public partial class Form1 : Form
    {
        string connStr = "";
        OleDbConnection conn;
        OleDbDataAdapter da;
        DataTable dt;
        BindingSource bs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dbPath = Path.Combine(Application.StartupPath, "irancell.accdb");
            connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath;

            conn = new OleDbConnection(connStr);
            da = new OleDbDataAdapter("SELECT * FROM Customer", conn);
            dt = new DataTable();
            da.Fill(dt);

            bs = new BindingSource();
            bs.DataSource = dt;
            dgvCustomer.DataSource = bs;

            txtMobile.DataBindings.Add("Text", bs, "mobileNo");
            txtFirstName.DataBindings.Add("Text", bs, "firstName");
            txtLastName.DataBindings.Add("Text", bs, "lastName");
            txtFatherName.DataBindings.Add("Text", bs, "fatherName");
            txtBirthdate.DataBindings.Add("Text", bs, "birthdate");
            txtMeliCode.DataBindings.Add("Text", bs, "meliCode");
        }

        private void txtSearchMobile_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchMobile.Text == "")
            {
                bs.Filter = "";
            }
            else
            {
                bs.Filter = "mobileNo LIKE '%" + txtSearchMobile.Text + "%'";
            }
        }

        private void lblFatherName_Click(object sender, EventArgs e)
        {

        }
    }
}
