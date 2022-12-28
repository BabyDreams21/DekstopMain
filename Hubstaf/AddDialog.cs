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
        SqlConnection con = new SqlConnection(utils.con);
        SqlCommand cmd;

        public AddDialog()
        {
            InitializeComponent();
            btndone.Enabled = false;
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            try
            {
                using(var client = new HttpClient())
                {
                    var endPoint = new Uri("https://aa05-158-140-172-123.ap.ngrok.io/api/todo");
                    DateTime dateNow = new DateTime();
                    var newTodo = new todos
                    {
                        idProject = 1,
                        nameTodo = "Ini Contoh Post",
                        description = "Ini Description",
                        changed = dateNow.ToString("dd/MM/yyyy").ToString(),
                        status = 0
                    };
                    var json = JsonConvert.SerializeObject(newTodo);
                    var payLoad = new StringContent(json, Encoding.UTF8,"application/json");
                    var result = client.PostAsync(endPoint, payLoad).Result.Content.ReadAsStringAsync().Result;
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(""+x.ToString());
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
