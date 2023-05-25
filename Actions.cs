public class Actions
{
    public Actions()
    {
    }

    public Result Start()
    {
        var result = new Result { Status = true, ErrorMessage = $"Start method: {System.Reflection.MethodInfo.GetCurrentMethod().Name}" };
        Logger.Instance.WriteToLog(LogType.Info, result.ErrorMessage);
        return result;
    }

    public Result Skiped()
    {
        var result = new Result { Status = true, ErrorMessage = $"Skipped logic in method: {System.Reflection.MethodInfo.GetCurrentMethod().Name}" };
        Logger.Instance.WriteToLog(LogType.Warning, result.ErrorMessage);
        return result;
    }

    public Result Error()
    {
        var result = new Result { Status = false, ErrorMessage = "I broke a logic" };
        Logger.Instance.WriteToLog(LogType.Error, result.ErrorMessage);
        return result;
    }
}
