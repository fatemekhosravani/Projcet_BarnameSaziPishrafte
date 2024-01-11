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

namespace kimi
{
    public partial class mosabeghe : Form
    {
        public mosabeghe()
        {
            InitializeComponent();
        }

        private void mosabeghe_Load(object sender, EventArgs e)
        {
            teamload();

        }
        private void teamload()
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\team.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select NameOfTeam from [dbo].[Table]", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["NameOfTeam"].ToString();
                comboBox1.Items.Add(name);
                comboBox2.Items.Add(name);
            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Match match = new Match();
            if (comboBox1.SelectedItem == comboBox2.SelectedItem || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("LOTFAN DOROST ENTEKHAB KONID");
            }
            else
            {
                match.label3.Text = this.comboBox1.SelectedItem.ToString();
                match.label4.Text = this.comboBox2.SelectedItem.ToString();
                match.Show();
            }
            

        }
    }
}
