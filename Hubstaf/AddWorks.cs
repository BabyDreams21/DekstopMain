using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hubstaf
{
    public partial class AddWorks : Form
    {
        public AddWorks()
        {
            InitializeComponent();
            btndone.Enabled = false;
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (gunaTextBox1.TextLength > 0)
            {
                btndone.Enabled = true;

            }
            else
            {
                btndone.Enabled = false;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndone_Click(object sender, EventArgs e)
        {
             async Task Main(string[] args)
            {
                // Create an HttpClient object
                using (var client = new HttpClient())
                {
                    // Set the request URI and content
                    var requestUri = "https://aa05-158-140-172-123.ap.ngrok.io/api/project";
                    var requestContent = new StringContent("{\"nameProject\":\"Ini Project 1\"}", Encoding.UTF8, "application/json");

                    // Make the POST request and get the response
                    HttpResponseMessage response = await client.PostAsync(requestUri, requestContent);

                    // Check the status code of the response
                    Console.WriteLine($"Response status code: {(int)response.StatusCode}");

                    // Read and print the response body
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Response body: {responseBody}");
                }
            }
        }

        
    }
}
