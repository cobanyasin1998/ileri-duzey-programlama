

using System.Diagnostics;

const string eventLogSource = "MySource";
const string eventLogName = "MyNewLog";
if (!EventLog.SourceExists(eventLogSource)) {
    EventLog.CreateEventSource(eventLogSource, eventLogName);
}
EventLog.WriteEntry(eventLogSource, "This is a test log message", EventLogEntryType.Information);
Console.WriteLine("Log message written to event log.");
Process.Start("eventvwr.exe", $"/c:{eventLogName}");