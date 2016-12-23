using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    class Log4NetLogger : ILogger
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // 2016-03-03 09:00:59,076 DEBUG thread=1 [{log4net:HostName=Deer}] Intelligenz.Utils.AssemblyInitialise.Initialise(c:\TFS\Dev\Source\IntelliFitness\Utils\AssemblyInitialise.cs:44) [logging system configured]

        // Date Time TYPE thread hostname fullyQualifiedName message

        private string TypeName;

        public void SetSource(string typeName)
        {
            TypeName = typeName;
        }

        public void Error(string message, string fqname = "", Exception exception = null)
        {
            string messageWithOrigin = "[" + fqname + "] " + message;

            Exception test = new Exception("This is an exception");

            //log.Error(messageWithOrigin);

            log.Error(messageWithOrigin, test);
        }

        //public void Error(string message, string fqname = "", Exception exception = null)
        //{
        //    log.Error(message, exception);
        //}

        public void Warn(string message)
        {
            log.Warn(message);
        }

        public void Debug(string message)
        {
            log.Debug(message);
        }

        public void Info(string message)
        {
            log.Info(message);
        }

        public void Fatal(string message)
        {
            log.Fatal(message);
        }
    }
}
