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
    public partial class AddContact : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=TECH-NB\SQLEXPRESS;Initial Catalog=Phonebook_DB;Integrated Security=True");
        public AddContact()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"insert into Contact_TB(Name,Surname,Phone_Number,Secondary_Number,Email,Addres) values ('{textBox1.Text}','{textBox2.Text}',{textBox3.Text},{textBox4.Text},'{textBox5.Text}','{textBox6.Text}')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
