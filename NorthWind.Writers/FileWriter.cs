namespace NorthWind.Writers

internal class FileWriter : IUserActionWriter
{
    public void Write(UserAction action)
    {
        FileWriter.AppendAllText("AppLogs.txt",
        string.Format("FileWriter: {0}, {1}, {2}".
        action.CreatedDateTime.Description))
    }
}