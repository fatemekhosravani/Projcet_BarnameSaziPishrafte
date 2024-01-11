using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           sabtteam sabtteam = new sabtteam();
           sabtteam.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List listTeam = new List();
            listTeam.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mosabeghe mosabeghe  = new mosabeghe();
            mosabeghe.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart chart = new chart();
            chart.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
