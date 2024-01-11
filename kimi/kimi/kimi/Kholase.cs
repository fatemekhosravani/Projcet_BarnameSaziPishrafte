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
    public partial class Kholase : Form
    {
        public Kholase()
        {
            InitializeComponent();
        }

        private void Kholase_Load(object sender, EventArgs e)
        {
            Match match = new Match();
            match.Close();
        }
    }
}
