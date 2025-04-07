
namespace BlApi;

    public interface ICustomer
    {
     int Create(BO.Customer item);
     BO.Customer? Read(int id);
     List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null);
     void Update(BO.Customer item);
     void Delete(int id);
     public bool isExistCustomer(int customerIdentitiy);

}

