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
    }
}
