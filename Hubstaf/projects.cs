using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hubstaf.Resources
{
    public partial class projects : UserControl
    {
        public projects()
        {
            InitializeComponent();
        }

        private string _name;
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; id.Text = value; }
        }
        public string projectName
        {
            get { return _name; }
            set { _name = value; name.Text = value; }
        }

        private void projects_Click(object sender, EventArgs e)
        {
            showTodo();
        }
        public void showTodo()
        {
            try
            {
                string url = "http://127.0.0.1:8000/api/todo";
                var webReq = (HttpWebRequest)WebRequest.Create(url);
                var webRes = (HttpWebResponse)webReq.GetResponse();
                if (webRes.StatusCode == HttpStatusCode.OK)
                {
                    var reader = new StreamReader(webRes.GetResponseStream());
                    string data = reader.ReadToEnd();
                    var jObj = JObject.Parse(data);
                    var getData = jObj["Data"];
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(getData.ToString(), (typeof(DataTable)));
                    int dataCount = dt.Rows.Count;

                    Form1.todoContainers.Controls.Clear();
                  

                    todos[] todo = new todos[dataCount];
                    for (int i = 0; i < todo.Length; i++)
                    {
                        if (id.Text.Equals(getData[i]["idProject"].ToString())){

                            //MessageBox.Show(getData[i]["changed"].ToString());
                            todo[i] = new todos();
                            todo[i].todoName = getData[i]["nameTodo"].ToString();
                            todo[i].Tanggal = getData[i]["changed"].ToString();
                            //projectClicked = this.projects_Click();
                            //todo[i].projects_Click += new System.EventHandler(this.showTodo);
                            if (Form1.todoContainers.Controls.Count < 0)
                            {
                                Form1.todoContainers.Controls.Clear();
                            }
                            else
                                Form1.todoContainers.Controls.Add(todo[i]);
                        }
                        else
                        {
                            MessageBox.Show("Data Not Found");
                        }
                    }

                    MessageBox.Show(getData.ToString());
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        void refresh(Object sender, EventArgs e)
        {

        }

        private void projects_Load(object sender, EventArgs e)
        {

        }

        private void projects_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(198, 223, 249);
        }

        private void projects_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
