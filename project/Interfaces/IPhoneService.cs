using PROJECT.Models;
using System.Collections.Generic;

namespace PROJECT.Interfaces 
{
    public interface IPhoneService
    {
        
    List<Phone> GetAll(int userId);
    
    Phone GetById(int id);  
    
    int Add(Phone newPhone,int userId);
   
    bool Update(int id, Phone newPhone,int userId);  
    
    bool Delete(int id);

    } 
}
