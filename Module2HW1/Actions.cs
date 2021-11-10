using System;

namespace Module2HW1
{
    public class Actions
    {
        public Actions()
        {
        }

        public Result Start()
        {
            Result result = new Result { Status = true, ErrorMessage = "Start method: " + System.Reflection.MethodInfo.GetCurrentMethod().Name };
            Logger.Instance.WriteToLog(LogType.Info, result.ErrorMessage);
            return result;
        }

        public Result Skiped()
        {
            Result result = new Result { Status = true, ErrorMessage = "Skipped logic in method: " + System.Reflection.MethodInfo.GetCurrentMethod().Name };
            Logger.Instance.WriteToLog(LogType.Warning, result.ErrorMessage);
            return result;
        }

        public Result Error()
        {
            Result result = new Result { Status = false, ErrorMessage = "I broke a logic" };
            Logger.Instance.WriteToLog(LogType.Error, result.ErrorMessage);
            return result;
        }
    }
}
