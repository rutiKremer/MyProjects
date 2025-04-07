using PROJECT.Models;
namespace PROJECT.Interfaces 
{
    public interface IUserService
    {
    List<User> GetAll();
    
    User GetById(int id);
    
    int Add(User newUser);
    
    bool Update(int id,User newUser);
   
    bool Delete(int id);
   
    int ExistUser(string name, string password);
    }

}



  
