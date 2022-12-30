using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hubstaf
{
    class Id
    {
        //public static int idMember { get; set; }
        public static int idMember;
        public static int idProject;

    }

    class koneksi
    {
        public string conlogin()
        {
            string apiEndPoint = "";
            return apiEndPoint;
        }
        public string conscreen()
        {
            string apiEndPoint = "";
            return apiEndPoint;
        }
        public string contodo()
        {
            string apiEndPoint = "";
            return apiEndPoint;
        }
        public string conproject()
        {
            string apiEndPoint = "";
            return apiEndPoint;
        }
        public string conmember()
        {
            string apiEndPoint = "";
            return apiEndPoint;
        }
    }
   class utils
    {
       public static string con = "Data Source = DESKTOP-M5SO53H\\SQLEXPRESS;Initial Catalog = backuphotel2;Integrated security = true;";

        public static string conn = "server=localhost;User ID=root;password=;database = test";
    }

    class session
    {
        public static string projname { get; set; }
        public static string appname { get; set; }
        public static string time { get; set; }
        public static string note { get; set; }
        public static string a { get; set; }
    }


    
}
