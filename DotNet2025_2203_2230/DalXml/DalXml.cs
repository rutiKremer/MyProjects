using System.Diagnostics;
using DalApi;

namespace Dal;

internal sealed class DalXml : IDal
{
    private static readonly DalXml instance = new DalXml();
    public static DalXml Instance => instance;
    public IProduct Product => new ProductImplementation();
    public ICustomer Customer => new CustomerImplementation();
    public ISale Sale => new SaleImplementation();
    private DalXml()
    {
    }
}
