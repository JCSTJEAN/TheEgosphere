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

        public filelogger(string fileNameToUse)
        {
            //to use, file has to use "\\filelog.txt" format
            directory = Directory.GetCurrentDirectory() + fileNameToUse;

            logWriter = new StreamWriter(fileNameToUse);
        }

        public void logToFile(string informationToLog)
        {
            localDateTime = DateTime.Now;
            logWriter.WriteLine("[" + localDateTime + "]  " + informationToLog);
        }

        //CALL THIS METHOD TO CLOSE STREAM
        //If possible consider implementing "using" to make it auto close
        public void closeStream(){ logWriter.Close(); }
    }
}
