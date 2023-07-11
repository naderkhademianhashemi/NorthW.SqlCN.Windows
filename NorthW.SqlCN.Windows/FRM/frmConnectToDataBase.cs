using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlCN.windows.forms
{
    public partial class frmConnectToDataBase : Form
    {
        public frmConnectToDataBase()
        {
            InitializeComponent();
        }
        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            string CNS;
            SqlConnection cnn;
            var db = txtDB.Text;
            var server = txtServer.Text;
            var user = txtUserName.Text;
            var pass = txtPassword.Text;
            var dbPath = "D:\\Program Files\\sql 2022\\MSSQL16.SQLEXPRESS\\MSSQL\\DATA\\master.mdf";
            var attchDB = "master";
            CNS = $@"Server=.\SQLExpress;AttachDbFilename={dbPath};Database={attchDB};Trusted_Connection=Yes;";
            CNS = $@"Data Source={server}; Initial Catalog={db};user id={user}; password ={pass}";
            cnn = new SqlConnection(CNS);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open  !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { cnn.Close(); }
            

        }
    }
}


