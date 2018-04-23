using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TheEgosphere
{
    class filelogger
    {
        private string directory;
        private DateTime localDateTime;
        private StreamWriter logWriter;

        //Pass in requested file name to create e.g "logforbulletsfired.txt"
        //Store append at the beginning the directory of the project file
        //Create a log Stream Writer 
        public filelogger(string fileNameAndExtension)
        {
            //to use, file has to use "\\filelog.txt" format
            directory = Directory.GetCurrentDirectory() + fileNameAndExtension;

            logWriter = new StreamWriter(fileNameAndExtension);
        }

        ~filelogger()
        {
            logWriter.Close();
        }

        public void logToFile(string informationToLog)
        {
            localDateTime = DateTime.Now;
            logWriter.WriteLine("[" + localDateTime + "]  " + informationToLog);
        }
    }
}
