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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public OleDbConnection con;
        public OleDbDataAdapter data;
        public OleDbCommandBuilder c;
        public BindingSource bs;
        public DataTable dt;
        public OleDbCommand com;
        public string yol, sorgu;
        private void baglan()
        {
           
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Database1.accdb");
            con.Open();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            baglan();
          //  doldur("select*from ogrenci");
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sorgu = "insert into ogrenci(ogrn,ad,soy,n1,n2,n3,p1,p2,ort,durum) values ('" + textBox1.Text + "','" + textBox2.Text + "','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+"','"+textBox10.Text+"')";
            com = new OleDbCommand(sorgu, con);
            com.ExecuteNonQuery();
        }
    }
}
