public class Book : Product
{
    public string Title {get; }
    public Book(int id, string name, decimal unitPrice, int unitsInStock, string title) :
        base(id, name, unitPrice, unitsInStock)
        {
            Title = title;
        }
}

public class Book2(int id, string name, decimal unitPrice, int unitsInStock, string title) :
    product(id,name, unitPrice,unitsInStock)
    {
        public string Title => title;
    }