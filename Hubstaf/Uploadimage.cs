using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Hubstaf
{
    public partial class Uploadimage : Form
    {
        MySqlConnection con = new MySqlConnection(utils.conn);   
        MySqlCommand cmd;
        public Uploadimage()
        {
            InitializeComponent();
        }


        #region Upload File
        //Upload File Button Click event
      
        private void btnUapload_Click(object sender, EventArgs e)
        {
            ImageConverter convert = new ImageConverter();
            byte[] b = (byte[])convert.ConvertTo(pictureBox1.Image, typeof(byte[]));

            OpenFileDialog ofd = new OpenFileDialog();
            Boolean uploadStatus = false;
            //DialogResult dr = this.openFileDialog1.ShowDialog();
            if (ofd.ShowDialog() ==DialogResult.OK)
            {
                foreach (String localFilename in ofd.FileNames)
                {

                   // pictureBox1 = 
                   // string url = "https://966c-158-140-172-123.ap.ngrok.io/api/screenshot";
                  //  string filePath = @"\";
                   // Random rnd = new Random();
                   // string uploadFileName = "Imag" + rnd.Next(9999).ToString();
                  //  uploadStatus = Upload(url, filePath, localFilename, uploadFileName);
                }
            }
            if (uploadStatus)
            {
                MessageBox.Show("File Uploaded");
            }
            else
            {
                MessageBox.Show("File Not Uploaded");
            }
        }
        // filepath = @"Some\Folder\";
        // url= "http://localhost:51389/api/FileHandlingAPI";
        // localFilename = "c:\newProduct.jpg"
        //uploadFileName="newFileName"
        bool Upload(string url, string filePath, string localFilename, string uploadFileName)
        {
            Boolean isFileUploaded = false;

            try
            {
                HttpClient httpClient = new HttpClient();


                var fileStream = File.Open(localFilename, FileMode.Open);
                var fileInfo = new FileInfo(localFilename);
                UploadFIle uploadResult = null;
                bool _fileUploaded = false;

                MultipartFormDataContent content = new MultipartFormDataContent();
                content.Headers.Add("filePath", filePath);
                content.Add(new StreamContent(fileStream), "\"file\"", string.Format("\"{0}\"", uploadFileName + fileInfo.Extension)
                        );

                Task taskUpload = httpClient.PostAsync(url, content).ContinueWith(task =>
                {
                    if (task.Status == TaskStatus.RanToCompletion)
                    {
                        var response = task.Result;

                        if (response.IsSuccessStatusCode)
                        {
                            uploadResult = response.Content.ReadAsAsync<UploadFIle>().Result;
                            if (uploadResult != null)
                                _fileUploaded = true;
                        }
                    }
                    fileStream.Dispose();
                });

                taskUpload.Wait();
                if (_fileUploaded)
                    isFileUploaded = true;
                httpClient.Dispose();

            }
            catch (Exception ex)
            {
                isFileUploaded = false;
            }
            return isFileUploaded;
        }
        #endregion

        #region Download File
        private void btndownload_Click(object sender, EventArgs e)
        {
            
            //Download File
           
                string url = "http://localhost:51389/Uploads/";
                string downloadFileName = txtFileName.Text.Trim();
                string downloadPath = Application.StartupPath + @"\Downloads\";

                if (!Directory.Exists(downloadPath))
                    Directory.CreateDirectory(downloadPath);

                Boolean isFileDownloaded = Download(url, downloadFileName, downloadPath);
                if (isFileDownloaded)
                {
                    MessageBox.Show("File Downloaded");
                }
                else
                {
                    MessageBox.Show("File Not Downloaded");
                }
            

            // url = http://localhost:51389/Uploads/"
            // downloadFileName = "new2.jpg"
            // downloadPath =  Application.StartupPath + "/Downloads/";
            bool Download(string url1, string downloadFileName1, string downloadFilePath)
            {
                string downloadfile = downloadFilePath + downloadFileName;
                string httpPathWebResource = null;
                Boolean ifFileDownoadedchk = false;
                ifFileDownoadedchk = false;
                WebClient myWebClient = new WebClient();
                httpPathWebResource = url1 + downloadFileName1;
                myWebClient.DownloadFile(httpPathWebResource, downloadfile);

                ifFileDownoadedchk = true;

                return ifFileDownoadedchk;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images |*.png;*.jpeg";
            if (of.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(of.FileName);
                Bitmap BMP = (Bitmap)img;
                pictureBox1.Image = BMP;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // string con ="datasource=localhost;port=3306;username=root;password=root";
                ImageConverter convert = new ImageConverter();
                byte[] b = (byte[])convert.ConvertTo(pictureBox1.Image, typeof(byte[]));
                con.Open();
                cmd = new MySqlCommand("insert into screenshort (image) values (@p)",con);
                cmd.Parameters.AddWithValue("@p", b);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("sukses");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
