using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public OleDbConnection con;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        public static string ad;
        private void baglan()
        {
           
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Database1.accdb");
            con.Open();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan();
            cmd = new OleDbCommand();
            cmd.Connection=con;
            cmd.CommandText="select * from uyeler  where kad='"+textBox1.Text+"'";
            dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                ad = textBox1.Text;
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Kulanıcı adı veya şifre yanlış");

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
