using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Hubstaf
{
    public partial class AddDialog : Form
    {
        //SqlConnection con = new SqlConnection(utils.con);
        SqlCommand cmd;
        koneksi con = new koneksi();

        public AddDialog()
        {
            InitializeComponent();
            btndone.Enabled = false;
        }

        private async void btndone_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString();
            using (var client = new HttpClient())
            {
                var payload = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("nameTodo",txttodo.Text),
                    new KeyValuePair<string, string>("changed",now),
                    new KeyValuePair<string, string>("status",0.ToString()),
                    new KeyValuePair<string, string>("idProject",Id.idProject.ToString()),
                    new KeyValuePair<string, string>("idProject",Id.idMember.ToString()),
                });


                var response = await client.PostAsync(con.contodo(), payload);
                MessageBox.Show(Id.idProject.ToString());


                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Succes");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something wrong");
                }


            }

        
        }
    
    

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDialog_Load(object sender, EventArgs e)
        {
           
        }

        private void txttodo_TextChanged(object sender, EventArgs e)
        {
            if (txttodo.TextLength > 0)
            {
                btndone.Enabled = true;

            }
            else
            {
                btndone.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure to exit ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
