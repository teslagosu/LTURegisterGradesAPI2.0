using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

using System.Net;
using System.IO;
using CourseDataAccess;
using RegisterDataAccess;
using Microsoft.Ajax.Utilities;

namespace TeacherGUI
{
    public partial class Form1 : Form
    {

        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        //register grades function
        private void button1_Click(object sender, EventArgs e)
        {
            
            string studentID = textBox_studid.Text;
            string courseCode = textBox_course_code.Text;
            string term = textBox_term.Text;
            string date = textBox_date.Text;
            string grade = textBox_grade.Text;
            string testNumber = textBox_test_number.Text;

            int applicationCode = getApplicationCourseCodeFromEpok(studentID,courseCode,term);

            string ssn = getSSNfromIdeal(studentID, applicationCode);
            Console.WriteLine(ssn);

            Register reg = new Register();
            reg.register_date = date;

            
            

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44331/api/Ladok");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"register_student_ssn\":\"" + ssn + "\"," +
               "\"register_course_occurance_code\":\"" + applicationCode + "\","+
               "\"register_test_number\":\"" + testNumber + "\","+
               "\"register_term\":\"" + term + "\","+
               "\"register_date\":\"" + date + "\","+
               "\"register_grade\":\"" + grade + "\",}";
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
            }
           

        }

        //not finnished function that will register the grades all-in-one.
        public void RegisterGrades()
        {
            string studentID = textBox_studid.Text;
            string courseCode = textBox_course_code.Text;
            string term = textBox_term.Text;

            int applicationCode = getApplicationCourseCodeFromEpok(studentID, courseCode, term);
            string ssn = getSSNfromIdeal(studentID, applicationCode);

            // Create a request for the URL.   
            WebRequest request = WebRequest.Create("");
            // If required by the server, set the credentials.  
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

           
        }

 

        
        //get the ssn from a person depending on studentID and occurance code ex: sebhyr-7, D0001N.
        public String getSSNfromIdeal(string studentId, int courseOccuranceCode)
        {
            //Get string from textbox1

            // Create a request for the URL.   
            WebRequest request = WebRequest.Create(
              "https://localhost:44346/api/Ideal?studentid="+studentId+"&occuranceCode="+courseOccuranceCode);
            // If required by the server, set the credentials.  
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server. 
            // The using block ensures the stream is automatically closed. 
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                var responseFromServer = reader.ReadToEnd();

                //declare a jObject.Parse and put the response as a json object
                var jo = JObject.Parse(responseFromServer);
                var parsedSsn = jo["student_ssn"].ToString();

                

                // Close the response.  
                response.Close();
                //return the string 
                return parsedSsn;
            }



        }
        // get the course application code "LTU-1234"
        public int getApplicationCourseCodeFromEpok(string studentId,string courseCode,string term)
        {
            //Get string from textbox1
            
            // Create a request for the URL.   
            WebRequest request = WebRequest.Create(
              "https://localhost:44366/api/Course?userName="+studentId+"&courseCode="+courseCode+"&courseTerm="+term);
            // If required by the server, set the credentials.  
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server. 
            // The using block ensures the stream is automatically closed. 
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                var responseFromServer = reader.ReadToEnd();

                //declare a jObject.Parse and put the response as a json object
                var jo = JObject.Parse(responseFromServer);
                var parsedCourseCode = jo["course_application_code"].ToString();

                //remove LTU- from the ApplicationCode.
                int newCourseApplicationCode = Int32.Parse(parsedCourseCode.Substring(4));
                
                // Close the response.  
                response.Close();
                //return the string from the json object
                return newCourseApplicationCode;
            }

           
           
        }


     
    }
}
