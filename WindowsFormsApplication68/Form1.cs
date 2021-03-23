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

namespace WindowsFormsApplication68
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1;
            OleDbCommand komut = new OleDbCommand();
            OleDbConnection baglan = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source=C:\Users\ertan\OneDrive\Desktop\vt.accdb");
            baglan.Open();
            komut.Connection = baglan;
            komut.Parameters.Clear();
            komut.CommandText = "Delete From liste Where numara=@n";
            komut.Parameters.AddWithValue("@n",Convert.ToInt32(textBox1.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");
            baglan.Close();
            
        }
    }
}
