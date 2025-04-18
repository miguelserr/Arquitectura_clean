namespace NorthWind.Writers;

public class DebugWriter : IUserActionWriter
{
    public void Write(UserAction action)
    {
        DebugWriter.WriteLine("ConsoleWriter : {0} , {1}, {2}",
        action.CreatedDateTime, action.User , action.Description);
    }
}