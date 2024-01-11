using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kimi
{
    
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }
       
        private void List_Load(object sender, EventArgs e)
        {
            LoadData1();
            teamload();
            Position();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selecte = label3.Text;
            string connection1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\player.mdf;Integrated Security=True";
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\team.mdf;Integrated Security=True";
            SqlConnection cn= new SqlConnection(connection);
            SqlConnection cn1= new SqlConnection(connection1);
            cn1.Open();
            cn.Open();
            SqlCommand cmd1 = new SqlCommand("delete [dbo].[Table] Where Team=@team", cn1);
            SqlCommand cmd = new SqlCommand("delete [dbo].[Table] Where NameOfTeam=@team",cn);
            cmd.Parameters.AddWithValue("@team", selecte);
            cmd1.Parameters.AddWithValue("@team", selecte);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            MessageBox.Show($"{selecte} deleted");
            cn1.Close();
            cn.Close();

        }
        private void LoadData1()
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\team.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Table]", cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void Loaddata2()
        {
            string team = label3.Text;
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\player.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Table] where Team=@team", cn);
            cmd.Parameters.AddWithValue("@team", team);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            cn.Close();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            string team = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            label3.Text = team;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\player.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Table] where Team=@team", cn);
            cmd.Parameters.AddWithValue("@team", team);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable mt = new DataTable();
            adapter.Fill(mt);
            dataGridView2.DataSource =mt;
            cn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string select = label4.Text;
            string connection1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\player.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection1);
            cn.Open();
            SqlCommand cmd = new SqlCommand("delete[dbo].[Table] Where Name=@name",cn);
            cmd.Parameters.AddWithValue("@name", select);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show($"{select} deleted");

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true;
            string name = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            label4.Text = name;
            textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Loaddata2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\team.mdf;Integrated Security=True";
                string team = textBox1.Text;
                string count = textBox2.Text;
                string coach = textBox3.Text;
                string old = label3.Text;
                SqlConnection cn = new SqlConnection(connection);
                cn.Open();
                SqlCommand cmd = new SqlCommand("update [dbo].[Table] set NameOfTeam=@team ,CountPlayer=@count , Coach=@coach where NameOfTeam=@old", cn);
                cmd.Parameters.AddWithValue("@old", old);
                cmd.Parameters.AddWithValue("@team", team);
                cmd.Parameters.AddWithValue("@count", count);
                cmd.Parameters.AddWithValue("@coach", coach);
                cmd.ExecuteNonQuery();
                cn.Close();
                string connection1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\player.mdf;Integrated Security=True";
                SqlConnection cn1 = new SqlConnection(connection1);
                cn1.Open();
                SqlCommand cmd1 = new SqlCommand("update[dbo].[Table] set Team = @team where Team = @old", cn1);
                cmd1.Parameters.AddWithValue("@old", old);
                cmd1.Parameters.AddWithValue("@team", team);
                cmd1.ExecuteNonQuery();
                cn1.Close();
                textBox1.Text = textBox2.Text = textBox3.Text = label3.Text = comboBox1.Text = comboBox2.Text = "";
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string old = label4.Text;
                string name = textBox4.Text;
                string family = textBox5.Text;
                string num = textBox6.Text;
                string age = textBox7.Text;
                string team = comboBox1.SelectedItem.ToString();
                string pose = comboBox2.SelectedItem.ToString();

                string connection1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\player.mdf;Integrated Security=True";
                SqlConnection cn1 = new SqlConnection(connection1);
                cn1.Open();
                SqlCommand cmd1 = new SqlCommand("update[dbo].[Table] set Name=@name,Family=@family ,Number =@num,Pose=@pose,Age=@age ,Team = @team where name = @old", cn1);
                cmd1.Parameters.AddWithValue("@old", old);
                cmd1.Parameters.AddWithValue("@name", name);
                cmd1.Parameters.AddWithValue("@family", family);
                cmd1.Parameters.AddWithValue("@num", num);
                cmd1.Parameters.AddWithValue("@pose", pose);
                cmd1.Parameters.AddWithValue("@team", team);
                cmd1.Parameters.AddWithValue("@age", age);
                cmd1.ExecuteNonQuery();
                cn1.Close();
                textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = label4.Text = "";
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }


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
            }
            cn.Close();
        }
        private void Position()
        {
            string[] Pose = { "GK", "SW", "CB", "LCB", "RCB", "RB", "LB", "LWB", "CDM", "RWB", "LM", "LCM", "CM", "RCM", "RM", "LW", "CAM", "RW", "SS", "CF", "ST" };
            for (int i = 0; i < Pose.Length; i++)
            {
                comboBox2.Items.Add(Pose[i]);
            }
        }

    }
}
