using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace kimi
{
    public partial class Match : Form
    {
        System.Timers.Timer t;
        int m, s;

        public Match()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void Match_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            string team1 = label3.Text;
            string team2 = label4.Text;
            playersDataLoad(team1);
            playersDataLoad(team2);
            label6.Text = label7.Text = "0";

        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 45 || m == 90 )
                {
                    if (m == 45)
                        MessageBox.Show("vaghte esterahat !!");
                    else
                        MessageBox.Show("payan bazi!!!");
                }
                TIMER_TB.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void Match_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            t.Stop();
            Kholase kholase = new Kholase();
            string khat = $"--------<<{label3.Text}>>--VS--<<{label4.Text}>>-------\n";
            File.AppendAllText("MATCHES.txt", khat);
            foreach (string itemtext in listBox1.Items)
            {
                string line = itemtext + "\n";
                File.AppendAllText("MATCHES.txt", line);
                kholase.listBox1.Items.Add(itemtext);
            }
            string khat2 = "-------------------------------------------------------\n";
            File.AppendAllText("MATCHES.txt", khat2);
            int Home = int.Parse(label6.Text);
            int Away = int.Parse(label7.Text);
            if (Home == Away)
            {
                Draw(label3.Text);
                Draw(label4.Text);
                kholase.label6.Text = "TASAVI";
            }
            else if (Home >Away)
            {
                WinLose(label3.Text, label4.Text);
                kholase.label6.Text = $"{this.label3} Barande Shod";
            }
            else if (Home < Away)
            {
                WinLose(label4.Text, label3.Text);
                kholase.label6.Text = $"{this.label4} Barande Shod";
            }
            kholase.label1.Text = this.label3.Text;
            kholase.label2.Text = Home.ToString();
            kholase.label4.Text = Away.ToString();
            kholase.label3.Text = this.label4.Text;
            kholase.Show();

        }
        private void playersDataLoad(string team)
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\player.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select  PlayerID,Name,Family,Number,Pose from [dbo].[Table] where Team =@team", cn);
            cmd.Parameters.AddWithValue("@team", team);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["PlayerID"].ToString()+ "," + reader["Name"].ToString()+ ","+ reader["Family"].ToString() + ","+ reader["Number"].ToString() + ","+ reader["Pose"].ToString();
                if (team == label3.Text)
                {
                    comboBox1.Items.Add(name);
                    comboBox3.Items.Add(name);
                    comboBox6.Items.Add(name);
                }
                else if (team == label4.Text)
                {
                    comboBox2.Items.Add(name);
                    comboBox4.Items.Add(name);
                    comboBox5.Items.Add(name);
                }
            }
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pick = comboBox2.SelectedItem.ToString();
            string[] A = playerPick(pick);
            int id = int.Parse(A[0]);
            Goal(id);
            int Gol = int.Parse(label7.Text);
            Gol++;
            label7.Text = Gol.ToString();
            listBox1.Items.Add(pick + $":GOAL Time : {TIMER_TB.Text}");
        }

        static void Goal(int ID )
        {
            string n = "";
            string connection1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\player.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(connection1);
            cn1.Open();
            SqlCommand cmd = new SqlCommand("select Goals from [dbo].[Table] where PlayerID =@ID", cn1);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 n = reader["Goals"].ToString();

            }
            int num = int.Parse(n);
            num++;
            cmd.Dispose();
            reader.Close();
            SqlCommand cmd1 = new SqlCommand("update[dbo].[Table] set Goals =@gol  where PlayerID =@ID", cn1);
            cmd1.Parameters.AddWithValue("@ID", ID);
            cmd1.Parameters.AddWithValue("@gol", num);
            cmd1.ExecuteNonQuery();
            cn1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pick = comboBox1.SelectedItem.ToString();
            string[] A = playerPick(pick);
            int id = int.Parse(A[0]);
            Goal(id);
            int Gol = int.Parse(label7.Text);
            Gol++;
            label6.Text = Gol.ToString();
            listBox1.Items.Add(pick + $":GOAL Time : {TIMER_TB.Text}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pick = comboBox3.SelectedItem.ToString();
            string[] A = playerPick(pick);
            int id = int.Parse(A[0]);
            Zard(id);
            listBox1.Items.Add(pick + $":Cart Zard Gerft Time : {TIMER_TB.Text}");


        }

        static string[] playerPick(string player)
        {
            string[] words = player.Split(',');
            return words;
        }
        private void Zard(int ID)
        {
            string n = "";
            string connection1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\player.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(connection1);
            cn1.Open();
            SqlCommand cmd = new SqlCommand("select YellowCard from [dbo].[Table] where PlayerID =@ID", cn1);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                n = reader["YellowCard"].ToString();

            }
            int num = int.Parse(n);
            num++;
            cmd.Dispose();
            reader.Close();
            SqlCommand cmd1 = new SqlCommand("update [dbo].[Table] set YellowCard =@yellow  where PlayerID =@ID", cn1);
            cmd1.Parameters.AddWithValue("@ID", ID);
            cmd1.Parameters.AddWithValue("@yellow", num);
            cmd1.ExecuteNonQuery();
            cn1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pick = comboBox4.SelectedItem.ToString();
            string[] A = playerPick(pick);
            int id = int.Parse(A[0]);
            Zard(id);
            listBox1.Items.Add(pick + $":Cart <Zard> Gerft Time : {TIMER_TB.Text}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string pick = comboBox6.SelectedItem.ToString();
            string[] A = playerPick(pick);
            int id = int.Parse(A[0]);
            Red(id);
            listBox1.Items.Add(pick + $":Cart !!<QERMEZ>!! Gerft Time : {TIMER_TB.Text}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pick = comboBox5.SelectedItem.ToString();
            string[] A = playerPick(pick);
            int id = int.Parse(A[0]);
            Red(id);
            listBox1.Items.Add(pick + $":Cart !!<QERMEZ>!! Gerft Time : {TIMER_TB.Text}");
        }

        private void Red(int ID)
        {
            string n = "";
            string connection1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\player.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(connection1);
            cn1.Open();
            SqlCommand cmd = new SqlCommand("select RedCard from [dbo].[Table] where PlayerID =@ID", cn1);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                n = reader["RedCard"].ToString();

            }
            int num = int.Parse(n);
            num++;
            cmd.Dispose();
            reader.Close();
            SqlCommand cmd1 = new SqlCommand("update [dbo].[Table] set RedCard =@red  where PlayerID =@ID", cn1);
            cmd1.Parameters.AddWithValue("@ID", ID);
            cmd1.Parameters.AddWithValue("@red", num);
            cmd1.ExecuteNonQuery();
            cn1.Close();
        }
        private void WinLose(string win,string lose)
        {
            string n = "";
            string pts = "0";
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\team.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select Win,Pts from [dbo].[Table] where NameOfTeam =@ID", cn);
            cmd.Parameters.AddWithValue("@ID", win);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                n = reader["Win"].ToString();
                pts = reader["Pts"].ToString();

            }
            int Pt = int.Parse(pts);
            Pt += 3;
            int num = int.Parse(n);
            num++;
            cmd.Dispose();
            reader.Close();
            SqlCommand cmd1 = new SqlCommand("update [dbo].[Table] set Win =@red ,Pts =@pt where NameOfTeam =@ID", cn);
            cmd1.Parameters.AddWithValue("@ID", win);
            cmd1.Parameters.AddWithValue("@red", num);
            cmd1.Parameters.AddWithValue("@pt", Pt);
            cmd1.ExecuteNonQuery();
            cmd1.Dispose();
            n = "";
            SqlCommand cmd2 = new SqlCommand("select Lose from [dbo].[Table] where NameOfTeam =@ID", cn);
            cmd2.Parameters.AddWithValue("@ID", lose);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                n = reader2["Lose"].ToString();
            }
            int numl = int.Parse(n);
            numl++;
            reader2.Close();
            SqlCommand cmd3 = new SqlCommand("update [dbo].[Table] set Lose =@red  where NameOfTeam =@ID", cn);
            cmd3.Parameters.AddWithValue("@ID", lose);
            cmd3.Parameters.AddWithValue("@red", numl);
            cmd3.ExecuteNonQuery();
            cn.Close();

        }
        private void Draw(string win)
        {
            string n = "";
            string pts = "0";
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\team.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select Draw,Pts from [dbo].[Table] where NameOfTeam =@ID", cn);
            cmd.Parameters.AddWithValue("@ID", win);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                n = reader["Draw"].ToString();
                pts = reader["Pts"].ToString();

            }
            int Pt = int.Parse(pts);
            Pt ++;
            int num = int.Parse(n);
            num++;
            cmd.Dispose();
            reader.Close();
            SqlCommand cmd1 = new SqlCommand("update [dbo].[Table] set Draw =@red ,Pts =@pt where NameOfTeam =@ID", cn);
            cmd1.Parameters.AddWithValue("@ID", win);
            cmd1.Parameters.AddWithValue("@red", num);
            cmd1.Parameters.AddWithValue("@pt", Pt);
            cmd1.ExecuteNonQuery();
            cmd1.Dispose();
            cn.Close();
        }
    }
}
