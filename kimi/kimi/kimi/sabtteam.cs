using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kimi
{
    public partial class sabtteam : Form
    {
        public sabtteam()
        {
            InitializeComponent();
        }

        private void sabtteam_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sabtBaziKon sabtBaziKon = new sabtBaziKon();
            sabtBaziKon.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\kimi\kimi\kimi\team.mdf;Integrated Security=True";
                SqlConnection cn;
                cn = new SqlConnection(connection);
                string NameTeam = textBox1.Text;
                string Coach = textBox2.Text;

                cn.Open();

                string qury1 = @"INSERT INTO [dbo].[Table] ( NameOfTeam , Coach, Win, Draw, Lose, Pts)  values ('" + NameTeam + "','" + Coach + "','0','0','0','0')";
                SqlCommand command = new SqlCommand(qury1, cn);
                command.ExecuteNonQuery();
                command.Dispose();
                cn.Close();
                MessageBox.Show("ahsant");
                textBox1.Text = textBox2.Text = "";
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

        }
    }
}
