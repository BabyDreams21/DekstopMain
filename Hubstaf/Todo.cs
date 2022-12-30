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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hubstaf
{
    public partial class Todo : UserControl
    {
        koneksi con = new koneksi();
        public Todo()
        {
            InitializeComponent();
            //showtodo();
        }

        private string _name;
        private string _time;
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; lblid.Text = value; }
        }
        public string todoname
        {
            get { return _name; }
            set { _name = value; lbltodo.Text = value; }
        }

        public string timename
        {
            get { return _time; }
            set {  _time = value; lbltime.Text = value; }
        }

        void getdata()
        {
            var webrequest = (HttpWebRequest)WebRequest.Create(con.conproject()); 
            var webrespon = (HttpWebResponse)webrequest.GetResponse();
            if ((webrespon.StatusCode == HttpStatusCode.OK))
            {
                var reader = new StreamReader(webrespon.GetResponseStream());
               
                string data = reader.ReadToEnd();
                var jp = JObject.Parse(data);
                var json = jp["Data"];


                var arr = JsonConvert.DeserializeObject<JArray>(json.ToString());
                dataGrid.DataSource = arr;
                MessageBox.Show(String.Format("berhasil"));
            }
            else
            {
                MessageBox.Show(String.Format("Status code = {0}", webrespon.StatusCode)); MessageBox.Show(String.Format("gagal"));
            }
        }

        public void showtodo()
        {
            try
            {
                string url = "https://0c6b-158-140-172-123.ap.ngrok.io/api/todo";
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

                    Form1.todosContainers.Controls.Clear();


                    todos[] todo = new todos[dataCount];
                    for (int i = 0; i < todo.Length; i++)
                    {
                        if (lblid.Text.Equals(getData[i]["idTodo"].ToString()))
                        {

                            //MessageBox.Show(getData[i]["changed"].ToString());
                            todo[i] = new todos();
                            todo[i].todoName = getData[i]["nameTodo"].ToString();
                            todo[i].Tanggal = getData[i]["changed"].ToString();
                            //projectClicked = this.projects_Click();
                            //todo[i].projects_Click += new System.EventHandler(this.showTodo);
                            if (Form1.todosContainers.Controls.Count < 0)
                            {
                                Form1.todosContainers.Controls.Clear();
                            }
                            else
                                Form1.todosContainers.Controls.Add(todo[i]);
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
                MessageBox.Show("" + x.ToString());
            }
        }



        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Todo_Load(object sender, EventArgs e)
        {

        }

        private void Todo_Click(object sender, EventArgs e)
        {
            showtodo();
        }
    }
}
