namespace NorthWind.Writers;

public class ConsoleWriter : IUserActionWriter
{
    public void Write(UserAction action)
    {
        ConsoleWriter.WriteLine("ConsoleWriter: {0}, {1}, {2}",
        action.CreatedDateTime, action.User,action.Description);
    }
}