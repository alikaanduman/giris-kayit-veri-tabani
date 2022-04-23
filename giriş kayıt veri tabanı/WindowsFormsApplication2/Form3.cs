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
    public partial class Form3 : Form
    {
        public Form3()
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
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sorgu = "insert into uyeler(kad,sifre)values('" + textBox1.Text + "','" + textBox2.Text + "')";
            com = new OleDbCommand(sorgu, con);
            com.ExecuteNonQuery();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            baglan();
            doldur("select*from uyeler");
          //  textdoldur();
    
        }
       private void doldur(string sorgu1)
        {
            data = new OleDbDataAdapter(sorgu1, con);
            dt = new DataTable();
            data.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
           // dataGridView1.DataSource = dt;

        }

    }


}
