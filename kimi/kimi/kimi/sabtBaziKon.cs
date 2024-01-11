using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kimi
{
    public partial class sabtBaziKon : Form
    {
        public sabtBaziKon()
        {
            InitializeComponent();
        }

        private void sabtBaziKon_Load(object sender, EventArgs e)
        {
            string[] Pose = { "GK", "SW", "CB", "LCB", "RCB", "RB", "LB", "LWB", "CDM", "RWB", "LM", "LCM", "CM", "RCM", "RM", "LW", "CAM", "RW", "SS", "CF", "ST" };
            for (int i = 0; i < Pose.Length; i++)
            {
                comboBox2.Items.Add(Pose[i]);
            }
            TeamsLOader();
           
        }
        public void TeamsLOader()
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
            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\player.mdf;Integrated Security=True";
                SqlConnection cn;
                cn = new SqlConnection(connection);
                string team = comboBox1.SelectedItem.ToString();
                string Name = Name_txt.Text;
                string family = Family_txt.Text;
                string pose = comboBox2.SelectedItem.ToString();
                int age = int.Parse(age_txt.Text);
                int num = int.Parse(Number_txt.Text);
                string phone = Phone_txt.Text;
                string email = email_txt.Text;
                Random r = new Random();
                string playerID = "1402" + r.Next(100, 999);
                int ID = int.Parse(playerID);
                cn.Open();
                string qury1 = @"INSERT INTO [dbo].[Table] (PlayerID, Name , Family,Age,Team,Number,Pose,phone,email,Goals,YellowCard,RedCard)  values ('" + ID + "','" + Name + "','" + family + "','" + age + "','" + team + "','" + num + "','" + pose + "','" + phone + "','" + email + "','0','0','0')";
                SqlCommand command = new SqlCommand(qury1, cn);
                command.ExecuteNonQuery();
                command.Dispose();
                cn.Close();
                MessageBox.Show("succecd");
                Name_txt.Text = Family_txt.Text = comboBox1.Text = comboBox2.Text = Phone_txt.Text = age_txt.Text = Number_txt.Text = email_txt.Text = "";
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
    } 
    
}
