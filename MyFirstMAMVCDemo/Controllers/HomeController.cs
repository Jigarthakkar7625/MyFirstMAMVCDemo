using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMAMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //foreach (var item in collection) //Cursor
            //{ //Open

            //    //Insert


            //}

            //Data Source = LAPTOP - LQDQBGOC; Initial Catalog = MyTestDB; User ID = sa; Password = 123


            //InsertRecord();

            //GetRecord();
           

            return View();
        }

        public void InsertRecord()
        {
            string cs = ConfigurationManager.ConnectionStrings["DefaultConnection1"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);

            con.Open(); //Insert, update, delete

            SqlCommand cmd = new SqlCommand("Insert into tblCourse values('Thakkar',11)",con);
            cmd.ExecuteNonQuery(); //record insert thase 


            con.Close();


        }

        public void GetRecord()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-LQDQBGOC;Initial Catalog=MyTestDB;User ID=sa;Password=123");

            //con.Open(); //Insert, update, delete/
            DataSet dataset = new DataSet(); //Disconnected architecture // Multiple table

            DataTable dt = new DataTable(); //Single table

            //SqlDataAdapter adapter = new SqlDataAdapter("Select * from tblCourse", con); //Inline query
            //adapter.Fill(dt);

            SqlCommand cmd = new SqlCommand("SP_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CourseName", "");

            //SqlDataReader reader = cmd.ExecuteReader();

            //if (reader.Read())
            //{
            //    while (reader.Read())
            //    {
            //        reader["Studentname1"];
            //    }
            //}

            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //adapter.Fill(dataset);

            //if (dataset.Tables.Count > 0)
            //{
            //    foreach (DataRow item in dataset.Tables[0].Rows)
            //    {
            //        var aa = item["StudentName1"];
            //    }
            //}
           


            //SqlCommand cmd = new SqlCommand("Insert into tblCourse values('Thakkar',11)", con);
            //cmd.ExecuteNonQuery(); //record insert thase 


            //con.Close();


        }
        public ActionResult MantanAbhi()
        {


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            //String file = Server.MapPath("~/files/_SQL_1660651922.pdf");
            //String mimeType = MimeMapping.GetMimeMapping(file);

            //byte[] stream = System.IO.File.ReadAllBytes(file);
            //return File(stream, mimeType);
            //return File(file, mimeType, "File Result.pdf");
            //string a = "alert('this is alert')";
            //return JavaScript(a);
            return View();
        }

        //if (TempData.ContainsKey("name"))
        //{ 
        //    string name = TempData["name"].ToString(); // returns "Bill" 
        //    TempData.Keep("name");
        //}
    }
}