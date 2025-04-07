using DalApi;
namespace Dal;

internal sealed class DalList : IDal
{
    public static DalList Instance = new DalList();
    public DalList get() { return Instance; }
    public IProduct Product => new ProductImplementation();
    public ISale Sale => new SaleImplementation();
    public ICustomer Customer => new CustomerImplementation();

    private DalList() { }
}
