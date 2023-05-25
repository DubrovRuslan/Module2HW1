public class Starter
{
    private Actions _actions;
    public Starter()
    {
        _actions = new Actions();
    }

    public void Run()
    {
        var rand = new Random();
        for (var i = 0; i < 100; i++)
        {
            Result result;
            var eventVariant = rand.Next(1, 4);
            if (eventVariant == 1)
            {
                result = _actions.Start();
            }
            else if (eventVariant == 2)
            {
                result = _actions.Skiped();
            }
            else if (eventVariant == 3)
            {
                result = _actions.Error();
            }
            else
            {
                continue;
            }

            if (result.Status == false)
            {
                Logger.Instance.WriteToLog(LogType.Error, "Action failed by a reason");
            }
        }

        File.WriteAllText("log.txt", Logger.Instance.GetAllLog());
    }
}
