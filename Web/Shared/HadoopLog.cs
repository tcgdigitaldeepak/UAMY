using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using Microsoft.Hadoop.WebHDFS;

namespace Web.Shared
{
    public class HadoopLog
    {
        public static void ErrorLogging(Exception ex)
        {
            string strPath = "C:\\Users\\deepakk\\Desktop\\Log.txt";
            if (!File.Exists(strPath))
            {
                File.Create(strPath).Dispose();
            }
            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine(DateTime.Now + " ===================================== Log Start =================================== ");
                sw.WriteLine("Error Message: " + ex.Message);
                sw.WriteLine("Stack Trace: " + ex.StackTrace);
                sw.WriteLine(DateTime.Now + " ===================================== Log End ===================================== ");

            }
        }

        public static void LogToHadoop()
        {
            try
            {
                //set variables
                string srcFileName = "C:\\Users\\deepakk\\Desktop\\Log.txt";
                string destFolderName = "/log_error";
                string destFileName = "err2.txt";

                //connect to hadoop cluster
                Uri myUri = new Uri("http://localhost:50070/");
                string userName = "DeepakK";
                WebHDFSClient myClient = new WebHDFSClient(myUri, userName);

                //drop destination directory (if exists)
                myClient.DeleteDirectory(destFolderName, true).Wait();

                //create destination directory
                myClient.CreateDirectory(destFolderName).Wait();


                //load file to destination directory
                myClient.CreateFile(srcFileName, destFolderName + "/" + destFileName).Wait();

                //Console.ReadLine();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Custom HADOOP " + ex.Message);
            }
        }
    }
}
