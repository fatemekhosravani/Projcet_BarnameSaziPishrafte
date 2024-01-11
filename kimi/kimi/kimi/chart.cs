using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kimi
{
    public partial class chart : Form
    {
        public chart()
        {
            InitializeComponent();
        }

        private void chart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] teams = new string[64];
             
            Random random = new Random();
            for (int n = 0; n < teams.Length; n++)
            {
                teams[n] = $"tema{n}";
            }
            int i = 0;
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\team.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select NameOfTeam from [dbo].[Table] ", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nameofteam = reader["NameOfTeam"].ToString();
                teams[i] = nameofteam;
                i++;

            }
            for (int n = 0; n < i; n++)
            {
                
            }
            string[] match = new string[i];
            for (int n = 0; (n < match.Length); n++)
            {
                match[n] = teams[n];
            }
            reader.Close();
            cn.Close();
            match = match.OrderBy(x => random.Next()).ToArray();
            int rounds = (int)Math.Log(i);
            for (int round = 1; round <= rounds; round++)
            {
                for (int j = 0; j < i / Math.Pow(2, round); j++)
                {
                    listBox1.Items.Add($"{match[j]},{match[i - 1 - j]}");
                }
            }
            foreach (string item in listBox1.Items)
            {
                comboBox1.Items.Add(item);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string picked = comboBox1.SelectedItem.ToString();
                string[] words = picked.Split(',');
                Match match = new Match();
                match.label3.Text = words[0];
                match.label4.Text = words[1];
                match.Show();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
           


        }
    }
}
