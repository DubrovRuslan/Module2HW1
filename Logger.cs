using System.Text;

public sealed class Logger
{
    private static readonly Logger _instance = new Logger();
    private StringBuilder _log;
    private StringBuilder _newlineInLog;

    static Logger()
    {
    }

    private Logger()
    {
        _log = new StringBuilder();
        _newlineInLog = new StringBuilder();
    }

    public static Logger Instance
    {
        get
        {
            return _instance;
        }
    }

    public void WriteToLog(LogType typeMsg, string msg)
    {
        _newlineInLog.Append(DateTime.Now.ToString());
        _newlineInLog.Append(" : ");
        _newlineInLog.Append(typeMsg);
        _newlineInLog.Append(" : ");
        _newlineInLog.Append(msg);
        Console.WriteLine(_newlineInLog);
        _log.Append(_newlineInLog + Environment.NewLine);
        _newlineInLog.Clear();
    }

    public string GetAllLog()
    {
        return _log.ToString();
    }
}
