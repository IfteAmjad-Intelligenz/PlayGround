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

        void Error(string message, Exception exception = null,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = null,
            [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = null,
            [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0);

        void Warn(string message, Exception exception = null,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = null,
            [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = null,
            [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0);

        void Debug(string message, Exception exception = null,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = null,
            [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = null,
            [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0);

        void Info(string message, Exception exception = null,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = null,
            [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = null,
            [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0);

        void Fatal(string message, Exception exception = null,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = null,
            [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = null,
            [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0);
    }
}
