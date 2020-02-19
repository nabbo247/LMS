using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;
using System.Net.Mail;
using LMSBL.Common;


namespace EmailService
{
    public partial class EmailService : ServiceBase
    {
        Timer timer = new Timer();

        public EmailService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteToFile("Service is started at " + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 10000; //number in milisecinds  
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            WriteToFile("Service is stopped at " + DateTime.Now);
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            WriteToFile("Service is recall at " + DateTime.Now);
        }


        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "\\LMSConfig.xml");
                XmlNodeList xmlNodeList = xmlDoc.SelectNodes("/Path/DBDetails");

                string DBServer = string.Empty;
                string LMSDBName = string.Empty;
                string LMSUserName = string.Empty;
                string LMSPassword = string.Empty;

                foreach (XmlNode xNode in xmlNodeList)
                {
                    DBServer = xNode["DBServer"].InnerText;
                    LMSDBName = xNode["LMSDBName"].InnerText;
                    LMSUserName = xNode["LMSUserName"].InnerText;
                    LMSPassword = xNode["LMSPassword"].InnerText;
                }

                XmlNodeList xmlNodeListSMTP = xmlDoc.SelectNodes("/Path/SMTPDetails");
                string Host = string.Empty;
                string port = string.Empty;
                string from = string.Empty;
                string userName = string.Empty;
                string password = string.Empty;

                foreach (XmlNode xNode in xmlNodeListSMTP)
                {
                    Host = xNode["Host"].InnerText;
                    port = xNode["port"].InnerText;
                    from = xNode["from"].InnerText;
                    userName = xNode["userName"].InnerText;
                    password = xNode["password"].InnerText;
                }


                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine("Email Service Started");
                }
                //string connectionString = "Data Source=DESKTOP-JOLRHRS\\SQLEXPRESS;Initial Catalog=LMSDB;User ID=sa;Password=Dinesh1981;Persist Security Info=True;";
                //string connectionString = "Data Source=DESKTOP-JOLRHRS\\SQLEXPRESS;Initial Catalog=LMSDB;Integrated Security=True";
                string connectionString = "Data Source = EC2AMAZ-4H52G4U\\SQLEXPRESS; Initial Catalog = LMSDB; Integrated Security = True";
                SqlConnection con = new SqlConnection(connectionString);
                string query = "select top 1 * from tblEmails where SentStatus is null and issent=0 order by DateCreated desc";

                using (var command = new SqlCommand(query, con))
                {
                    
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);
                    
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                SmtpClient smtp = new SmtpClient();
                                smtp.UseDefaultCredentials = false;                                
                                smtp.Credentials = new System.Net.NetworkCredential(userName, password);
                                smtp.Host = Host;
                                smtp.Port = 587;
                                smtp.EnableSsl = true;
                               

                                MailMessage email = new MailMessage(from, Convert.ToString(dr["EmailTo"]));
                                email.Subject = Convert.ToString(dr["EmailSubject"]);
                                email.Body = Convert.ToString(dr["EmailBody"]);
                                email.IsBodyHtml = true;
                                email.Priority = MailPriority.High;
                                string updateQuery = string.Empty;
                                try
                                {
                                    using (StreamWriter sw = File.AppendText(filepath))
                                    {
                                        sw.WriteLine("Email Sending Started");
                                    }
                                    smtp.Send(email);

                                    using (StreamWriter sw = File.AppendText(filepath))
                                    {
                                        sw.WriteLine("Email Sending Ended");
                                    }
                                    updateQuery = "update tblEmails set issent=1, DateSent=GETDATE(), sentstatus='Sent' where id=" + Convert.ToInt32(dr["Id"]) + "";

                                   
                                    using (SqlConnection conNew = new SqlConnection(connectionString))
                                    {
                                        using (SqlCommand cmd = new SqlCommand(updateQuery, conNew))
                                        {
                                            cmd.CommandType = CommandType.Text;
                                            conNew.Open();
                                            int rowsAffected = cmd.ExecuteNonQuery();
                                            conNew.Close();
                                        }
                                    }                                                                    

                                }
                                catch (Exception ex)
                                {                                  
                                    using (StreamWriter sw = File.AppendText(filepath))
                                    {
                                        sw.WriteLine("Dinesh 111 :-   " + ex.Message + "Dinesh 222 :- " + ex.StackTrace);
                                    }
                                    updateQuery = "update tblEmails set sentstatus='Failed' where id=" + Convert.ToInt32(dr["Id"]) + "";
                                                                        
                                    using (SqlConnection conNew = new SqlConnection(connectionString))
                                    {
                                        using (SqlCommand cmd = new SqlCommand(updateQuery, conNew))
                                        {
                                            cmd.CommandType = CommandType.Text;
                                            conNew.Open();
                                            int rowsAffected = cmd.ExecuteNonQuery();
                                            conNew.Close();
                                        }
                                    }                                    
                                    continue;
                                }
                                finally
                                {
                                    con.Close();
                                    
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine("Dinesh :-   "+ex.StackTrace);
                }
            }
        }
    }
}
