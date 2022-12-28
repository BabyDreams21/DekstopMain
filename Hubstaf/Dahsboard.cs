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

namespace Hubstaf
{
    public partial class Dahsboard : Form
    {
        SqlConnection m = new SqlConnection(utils.con);
        SqlCommand cmd;
        public Dahsboard()
        {
            InitializeComponent();
        }

        void displaytime()
        {
           Timer timer = new Timer();
           timercontainer.Controls.Add(timer);
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {
            string url ="a";
            cmd = new SqlCommand();
        }
    }
}
