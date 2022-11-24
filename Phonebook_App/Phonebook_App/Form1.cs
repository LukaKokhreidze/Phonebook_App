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
using Microsoft.Win32;

namespace Phonebook_App
{
    public partial class Phonebook : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=TECH-NB\SQLEXPRESS;Initial Catalog=Phonebook_DB;Integrated Security=True");
        public Phonebook()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            SeeContact contact = new SeeContact();
            contact.TopLevel = false;
            panel1.Controls.Add(contact);
            contact.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            AddContact contact = new AddContact();
            contact.TopLevel = false;
            panel1.Controls.Add(contact);
            contact.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            EditInfo info = new EditInfo();
            info.TopLevel = false;
            panel1.Controls.Add(info);
            info.Show();
        }
    }
}
