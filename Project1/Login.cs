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

namespace Project1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void login_butt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "Select *" +
                " From Project_Manager" +
                " Where eID = \'" + username_text.Text + "\' and pmPassword = \'" + pass_text.Text + "\'";

            string query1 = "Select *" +
                " From Administrator" +
                " Where eID = \'" + username_text.Text + "\' and adminPassword = \'" + pass_text.Text + "\'";

            SqlDataAdapter sqlData = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            sqlData.Fill(table);

            SqlDataAdapter sqlData1 = new SqlDataAdapter(query1, conn);
            DataTable table1 = new DataTable();
            sqlData1.Fill(table1);


            if (table.Rows.Count == 1 || table1.Rows.Count == 1)
            {
                this.Hide();
                main_menu menu = new main_menu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
            else
            {
                string message = "שם המשתמש או הסיסמא שגויים";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
        }

    }
}
