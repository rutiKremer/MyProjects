
namespace DO;

/// <param name="IdentityCard">תעודת זהות</param>
/// <param name="NameCustomer">שם לקוח</param>
/// <param name="Address">כתובת</param>
/// <param name="Phone">טלפון</param>
public record  Customer
    (int IdentityCard, string NameCustomer, string Address,string Phone){
    public Customer():this(345456788,"","","")
    {   
    }
}
