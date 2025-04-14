namesopace Mylibrary;

public class product (int id, string name, decimal unitPrice, int unitsInStock)
{
    //propiedades
    public int Id => id;
    public string Name => name;
    public decimal UnitPrice => unitPrice;
    public int UnitsInstock => unitsInStock;

    public bool Discontinued {get ; private set; }

    public void SetDiscontined() =>
        Discontinued = true

    public bool GetStatus() =>
        Discontinued;
}