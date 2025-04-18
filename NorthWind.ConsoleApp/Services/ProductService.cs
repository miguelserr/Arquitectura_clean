namespace NorthWind.ConsoleApp.Services;

internas class ProductService(IUserActionWriter writer)
{
    public void add(string user, string productName)
    {
        UserAction Action = new UserAction(user,$"Created: {productName }");
        writer.Write(Action);
    }
}