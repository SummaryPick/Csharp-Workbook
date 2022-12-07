using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumenting;
class Program
{
    static void Main(string[] args)
    {
        //Write to a text file in the project folder
        Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
        Trace.AutoFlush = true;

        Debug.WriteLine("Debug is watching.");
        Trace.WriteLine("Trace is watching.");

        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", 
            optional: true, reloadOnChange: true);

        IConfigurationRoot configuration = builder.Build();

        var ts = new TraceSwitch(
            displayName: "PacktSwtich",
            description: "This switch is set via a JSON config.");
        
        configuration.GetSection("PacktSwitch").Bind(ts);

        Trace.WriteLineIf(ts.TraceError, "TraceError");
        Trace.WriteLineIf(ts.TraceWarning, "TraceWarning");
        Trace.WriteLineIf(ts.TraceInfo, "Trace Information");
        Trace.WriteLineIf(ts.TraceVerbose, "TraceVerbose");
    }
}
