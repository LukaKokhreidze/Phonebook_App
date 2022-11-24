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
    public partial class EditInfo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=TECH-NB\SQLEXPRESS;Initial Catalog=Phonebook_DB;Integrated Security=True");
        public EditInfo()
        {
            InitializeComponent();
        }
        public static DataTable Info { get; set; }
        private void EditInfo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from Contact_TB where Name = '{textBox7.Text}' AND Phone_Number = {textBox8.Text}", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //Info = dt;
            foreach (DataRow item in dt.Rows)
            {
                label1.Text += item["Name"];
                label2.Text += item["Surname"];
                label4.Text += item["Phone_Number"];
                label3.Text += item["Secondary_Number"];
                label5.Text += item["Email"];
                label6.Text += item["Addres"];
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"update Contact_TB set Name = '{textBox1.Text}', Surname = '{textBox2.Text}',Phone_Number = {textBox3.Text}, Secondary_Number = {textBox4.Text}, Email = '{textBox5.Text}',Addres='{textBox6.Text}' where Name = '{textBox7.Text}' AND Phone_Number = {textBox8.Text}",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
