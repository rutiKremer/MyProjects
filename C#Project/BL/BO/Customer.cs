
namespace BO;

    public class Customer
    {
    public int IdentityCard { get; set; }
    public string NameCustomer { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
     public Customer(int IdentityCard, string NameCustomer, string Address, string Phone)
    {
        this.IdentityCard = IdentityCard;
        
        this.NameCustomer = NameCustomer;
        
        this.Address = Address;
        
        this.Phone = Phone;
    }
}

