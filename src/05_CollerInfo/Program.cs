using System.Diagnostics;
using System.Runtime.CompilerServices;

void DoProcessing() => TraceMessage("Something happened.");

void TraceMessage(string message,
    [CallerMemberName] string memberName = "",
    [CallerFilePath] string sourceFilePath = "",
    [CallerLineNumber] int sourceLineNumber = 0)
{
    Trace.WriteLine("\n!!!!!!INFO!!!!!!");
    Trace.WriteLine("message: " + message);
    Trace.WriteLine("member name: " + memberName);
    Trace.WriteLine("source file path: " + sourceFilePath);
    Trace.WriteLine("source line number: " + sourceLineNumber);
    Trace.WriteLine("!!!!!!END!!!!!!\n");
}

DoProcessing();
Console.ReadKey();