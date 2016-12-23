using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    public interface ILogger
    {
        void SetSource(string typeName);

        //void Error(string message, string fqname = "");
        void Error(string message, string fqname = "", Exception exception = null);
        void Warn(string message);
        void Debug(string message);
        void Info(string message);
        void Fatal(string message);
    }
}
