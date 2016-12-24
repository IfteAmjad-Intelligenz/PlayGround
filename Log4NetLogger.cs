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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Log4NetLogger));
        private static readonly bool isErrorEnabled = log.IsErrorEnabled;
        private static readonly bool isWarnEnabled = log.IsWarnEnabled;
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly bool isInfoEnabled = log.IsInfoEnabled;
        private static readonly bool isFatalEnabled = log.IsFatalEnabled;

        // 2016-03-03 09:00:59,076 DEBUG thread=1 [{log4net:HostName=Deer}] Intelligenz.Utils.AssemblyInitialise.Initialise(c:\TFS\Dev\Source\IntelliFitness\Utils\AssemblyInitialise.cs:44) [logging system configured]

        // Date Time TYPE thread hostname fullyQualifiedName message

        private string TypeName;

        public void SetSource(string typeName)
        {
            TypeName = typeName;
        }

        public void Error(string message, Exception exception = null)
        {
            if (isErrorEnabled)
            {
                string Message = message;

                if (exception != null)
                {
                    Message = Message + " [System Exception: " + exception.Message + "]";
                }

                log.Error(Message);
            }
        }

        public void Warn(string message, Exception exception = null)
        {
            if (isWarnEnabled)
            {
                string Message = message;

                if (exception != null)
                {
                    Message = Message + " [System Exception: " + exception.Message + "]";
                }

                log.Warn(Message);
            }
        }

        public void Debug(string message, Exception exception = null)
        {
            if (isDebugEnabled)
            {
                string Message = message;

                if (exception != null)
                {
                    Message = Message + " [System Exception: " + exception.Message + "]";
                }

                log.Debug(Message);
            }
        }

        public void Info(string message, Exception exception = null)
        {
            if (isInfoEnabled)
            {
                string Message = message;

                if (exception != null)
                {
                    Message = Message + " [System Exception: " + exception.Message + "]";
                }

                log.Info(Message);
            }
        }

        public void Fatal(string message, Exception exception = null)
        {
            if (isFatalEnabled)
            {
                string Message = message;

                if (exception != null)
                {
                    Message = Message + " [System Exception: " + exception.Message + "]";
                }

                log.Fatal(Message);
            }
        }
    }
}
