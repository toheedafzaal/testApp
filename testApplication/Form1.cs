using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testApplication
{
    [ComVisibleAttribute(true)]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //getVideoIds();
            //this.webBrowser1.ObjectForScripting = this;
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("testApplication.HTML.htm"));
            //webBrowser1.DocumentText = reader.ReadToEnd();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        //public string getVideoIds()
        //{
        //    //var constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVimeo;User ID=sa;Password=sa";
        //    var constring = ConfigurationManager.ConnectionStrings["vimeocs"].ConnectionString;
        //    SqlConnection con = new SqlConnection(constring);
        //    SqlCommand selectvideoids = new SqlCommand("Select VideoId from tblVideos", con);
        //    DataTable dt = new DataTable();
        //    con.Open();
        //    SqlDataReader selectedVids = selectvideoids.ExecuteReader();
        //    dt.Load(selectedVids);
        //    con.Close();
        //    var ids = new List<int>();
        //    //var ids = new object();
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        ids.Add(Convert.ToInt32(row["VideoId"]));
        //    }
        //    List<string> videoids = ids.ConvertAll<string>(x => x.ToString());
        //    //String.Join(", ", videoids);
        //    var idssss = String.Join(", ", videoids);
        //    //Console.WriteLine(String.Join(", ", videoids));
        //    //var videoids = dt.Rows;
        //    //string[] videoids = new string[] { "590305554", "36319428", "95212995", "67423133", "131484417" };
        //    //int[] videoids = { 590305554, 36319428, 95212995, 67423133, 131484417 };
        //    //string test = "1323";
        //    return idssss;
        //}

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
