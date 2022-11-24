using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Phonebook_App
{
    public partial class SeeContact : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=TECH-NB\SQLEXPRESS;Initial Catalog=Phonebook_DB;Integrated Security=True");
        public SeeContact()
        {
            InitializeComponent();
        }

        private void SeeContact_Load(object sender, EventArgs e)
        {
            conn.Open();
            //SqlCommand cmd = new SqlCommand($"select * [except Id] from Contact_TB",conn);
            //SqlCommand cmd = new SqlCommand($"select Name,Surname,Phone_Number,Secondary_Number,Email,Addres from Contact_TB",conn);
            SqlCommand cmd = new SqlCommand($"select * from Contact_TB",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
