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

namespace Hubstaf
{
    public partial class Login : Form
    {
        koneksi con = new koneksi();
 
       
        
        public class User
        {
            public string email { get; set; }
            public string password { get; set; }
        }
        public Login()
        {
            InitializeComponent();
            //_client = new HttpClient();
            //_client.BaseAddress("https://b941-158-140-172-123.ap.ngrok.io/");
            //_client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        //public async Task<List<User>> getList(){

        //}
        // static HttpClient client;
        // var values = new Dictionary<String, String>{
        //     {"email", gunaTextBox1.Text },
        //     {"password", gunaTextBox2.Text}
        // };
        // var content = new FormUrlEncodedContent(values);
        // var response = await client.PostAsync("https://b941-158-140-172-123.ap.ngrok.io/api/login", content);
        // var resString = response.content.ReadAsStringAsync();


        // static async Task run()
        // {
        //     client.BaseAddress = new Uri("https://ee0d-158-140-172-123.ap.ngrok.io");
        //     client.DefaultRequestHeaders.Accept.Clear();
        //     client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        // }
        // static async Task<Uri> CreateProductAsync(User user)
        // {
        //     HttpResponseMessage response = await client.PostAsJsonAsync(
        //         "api/products", user);
        //     response.EnsureSuccessStatusCode();

        //     // return URI of the created resource.
        //     return response.Headers.Location;
        // }
        // public static void POST(string url, string jsonContent)
        // {
        //     try
        //     {
        //         url = "https://b941-158-140-172-123.ap.ngrok.io/api/login" + url;
        //         HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //         request.Method = "POST";

        //         System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
        //         Byte[] byteArray = encoding.GetBytes(jsonContent);

        //         request.ContentLength = byteArray.Length;
        //         request.ContentType = @"application/json";

        //         using (Stream dataStream = request.GetRequestStream())
        //         {
        //             dataStream.Write(byteArray, 0, byteArray.Length);
        //         }
        //         long length = 0;
        //         try
        //         {
        //             using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //             {
        //                 length = response.ContentLength;

        //             }
        //         }
        //         catch
        //         {
        //             throw;
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         MessageBox.Show(ex.Message);
        //     }

        // }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Login.POST("login-validate", "{ \"email\":" + gunaTextBox1.Text + " ,\"password\":" + gunaTextBox2.Text + "}");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


            // }
            //on my login button click 
            //private void btnLogin_Click(object sender, EventArgs e)
            //{
            //    CallAPI.POST("login-validate", "{ \"email\":" + txtUserName.Text + " ,\"password\":" + txtPassword.Text + ",\"time\": " + DateTime.Now.ToString("yyyy-MM-dd h:mm tt") + "}");
            //}
        }

        private async void btndone_Click(object sender, EventArgs e)
        {
            string username = usr.Text;
            string password = pwd.Text; MessageBox.Show(username, password);

            using (var client = new HttpClient())
            {
                var payload = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("email", username),
                    new KeyValuePair<string, string>("password", password)

                });

                var response = await client.PostAsync(con.conlogin(), payload);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync(); 
                    var obj = JObject.Parse(responseContent); 
                    var getIdp = obj["Data"]["idProject"];
                    var getId = obj["Data"]["idMember"];
                   Id.idMember = Convert.ToInt32(getId);
                    Id.idProject = Convert.ToInt32(getIdp);
                    Form1 form = new Form1();
                    form.Show(); 
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
// Login was unsuccessful. Display an error message to the user. 


            }
        }

        //using (var client = new HttpClient())
        //{
        //    var payload = new FormUrlEncodedContent(new[]
        //    {
        //new KeyValuePair<string, string>("email", username),
        //new KeyValuePair<string, string>("password", password)
        //   });

        //     var response = await client.PostAsync(apiEndpoint, payload);

        //    var responseContent = await response.Content.ReadAsStringAsync();
        //    var obj = JObject.Parse(responseContent);
        //    var getId = obj["Data"]["idMember"];
        //    Id.idMember = Convert.ToInt32(getId);

        //    Form1 form = new Form1();
        //    form.Show();
        //    this.Hide();
        //    if (response.IsSuccessStatusCode)
        //    {
        //        // Login was successful. Extract the necessary information from the response,
        //        // such as an authentication token, and close the login form.
        //        MessageBox.Show("Succes");
        //        Form1 j = new Form1();
        //        j.Show();
        //        this.Hide();
        //        this.Close();
        //    }
        //    else
        //    {
        //        // Login was unsuccessful. Display an error message to the user.
        //        MessageBox.Show("Invalid username or password.");
        //    }
        //}



    

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked== false)
            {
                gunaTextBox2.UseSystemPasswordChar = true;
            }
            else
            {
                gunaTextBox2.UseSystemPasswordChar = false;
            }
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "Email")
            {
                gunaTextBox1.Text = "";

                gunaTextBox1.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                gunaTextBox1.Text = "Email";

                gunaTextBox1.ForeColor = Color.DimGray;
            }
        }

        private void gunaTextBox2_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "Password")
            {
                gunaTextBox2.Text = "";

                gunaTextBox2.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox2_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "")
            {
                gunaTextBox2.Text = "Password";

                gunaTextBox2.ForeColor = Color.DimGray;
            }
        }
    }
}
