using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Net.Http.Formatting;
using MySqlX.XDevAPI;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Hubstaf.Resources;
using MySql.Data.MySqlClient;

namespace Hubstaf
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(utils.conn);
        MySqlCommand cmd;
       
        System.Timers.Timer t;
        int h, m, s;
        public static Panel todoContainers;
        bool restore = true;
        
        public Form1()
        {
            InitializeComponent();
            shows();
            showProject();
            timer1.Enabled = true;
           
            //todoContainers = todoContainer;
        }

        private void set_Restore()
        {
            {
                if (this.WindowState == FormWindowState.Maximized) //Here the "is" functions is
                {
                    restore = true; //Sets the bool "restore" to true when the windows maximized
                }
                else
                {
                    restore = false; //Sets the bool "restore" to false when the windows isn't maximized
                }
            }
        }

        void timer()
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        void shows() 
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            startstrip.Visible = true;
            stopstrip.Visible = false;
            pictureBox4.Visible = false;
        }
        void hideS()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            startstrip.Visible =false;
            stopstrip.Visible = true;
            pictureBox4.Visible = true;
        }
        

        private void showProject()
        {
            try
            {
                string url = "https://aa05-158-140-172-123.ap.ngrok.io/api/project";
                var webrequest = (HttpWebRequest)WebRequest.Create(url);
                var webrespon = (HttpWebResponse)webrequest.GetResponse();
                if ((webrespon.StatusCode == HttpStatusCode.OK))
                {

                    var reader = new StreamReader(webrespon.GetResponseStream());
                    string data = reader.ReadToEnd();
                    var obj = JObject.Parse(data);
                    var getdata = obj["Data"];

                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(getdata.ToString(), (typeof(DataTable)));

                    int dataCount = dt.Rows.Count;
                    projects[] projectList = new projects[dataCount];
                    for (int i = 0; i < projectList.Length; i++)
                    {
                        projectList[i] = new projects();
                        projectList[i].projectName = getdata[i]["nameProject"].ToString();
                        projectList[i].Id = getdata[i]["idProject"].ToString();
                        if (projectContainer.Controls.Count < 0)
                        {
                            projectContainer.Controls.Clear();
                        }
                        else
                            projectContainer.Controls.Add(projectList[i]);
                    }

                }
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                txtresult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

            }));
            
        }

        private void CaptureMyScreen()
        {
            try
            {
                timer1.Start();
               
                Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
                
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
              
              // captureBitmap.Save(ms, ImageFormat.Jpeg);
                pictureBox3.Image = captureBitmap;
                MemoryStream ms = new MemoryStream();
                
                ImageConverter convert = new ImageConverter();
                byte[] b = (byte[])convert.ConvertTo(pictureBox3.Image, typeof(byte[]));
                cmd = new MySqlCommand("Insert into screenshort (image,date,timer) values (@a,@c,@b)", con);
                cmd.Parameters.AddWithValue("@a",b);
                cmd.Parameters.AddWithValue("@b",txtresult.Text);
                cmd.Parameters.AddWithValue("@c", DateTime.Now);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Screen Captured");
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaTextBox2_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "Search Project")
            {
                gunaTextBox2.Text = "";

                gunaTextBox2.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox2_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "")
            {
                gunaTextBox2.Text = "Search Project";

                gunaTextBox2.ForeColor = Color.DimGray;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
           AddDialog d = new AddDialog();
            d.Show();
        }

        private void gunaTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer();
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
            t.Start();
            hideS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            t.Stop();
            shows();
        }

        private void gunaTextBox4_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox4.Text == "Create a to-do")
            {
                gunaTextBox4.Text = "";

                gunaTextBox4.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox4_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox4.Text == "")
            {
                gunaTextBox4.Text = "Create a to-do";

                gunaTextBox4.ForeColor = Color.DimGray;
            }
        }

        private void gunaTextBox3_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox3.Text == "Create a to-do")
            {
                gunaTextBox3.Text = "";

                gunaTextBox3.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox3_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox3.Text == "")
            {
                gunaTextBox3.Text = "Create a to-do";

                gunaTextBox3.ForeColor = Color.DimGray;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            CaptureMyScreen();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("Helo");
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("info");
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void projectcontainer1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CaptureMyScreen();
        }

       

        private void stopstrip_Click(object sender, EventArgs e)
        {
            t.Stop();
            shows();
        }

        private void startstrip_Click(object sender, EventArgs e)
        {
            t.Start();
            hideS();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AddWorks s = new AddWorks();
            s.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnnor_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure to close this page?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
