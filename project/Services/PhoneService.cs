 using PROJECT.Models;
 using PROJECT.Interfaces;
 using System.Text.Json;
 namespace PROJECT.Services;

 public class PhoneService : IPhoneService
 {

    private List<Phone> phone;
    private string fileName = "Phone.json";
    public PhoneService()
    {
       this.fileName = Path.Combine("Data", "phone.json");

       using(var jsonFile = File.OpenText(fileName))
       {
            phone = JsonSerializer.Deserialize<List<Phone>>(jsonFile.ReadToEnd(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
       }    
    }

       private void saveToFile()
      {
        File.WriteAllText(fileName, JsonSerializer.Serialize(phone));
      }

      public List<Phone> GetAll(int userId)
      {
         return phone.FindAll(t => t.UserId==userId);
      }

      public Phone GetById(int id)
      {
         return phone.First( p => p.Id == id);
      }

      public int Add(Phone newPhone,int userId)
      {
         newPhone.UserId=userId;
        if (phone.Count == 0)
            newPhone.Id = 1;
        else
            newPhone.Id = phone.Max(p => p.Id) + 1;

        phone.Add(newPhone);
        saveToFile();
        return newPhone.Id;
      }

      public  bool Update(int id, Phone newPhone,int userId)
      {
         if(id!=newPhone.Id)
            return false;
         var existingPhone = GetById(id);
         if (existingPhone == null)
            return false;           
         newPhone.UserId=userId;
         var index = phone.IndexOf(existingPhone);
         if (index == -1)
            return false;
         phone[index] = newPhone;
         saveToFile();
         return true;
      }

      public bool Delete(int id)
      {
        var existingPhone = GetById(id);
        if (existingPhone == null)
            return false;

        var index = phone.IndexOf(existingPhone);
        if (index == -1)
            return false;

        phone.RemoveAt(index);
        saveToFile();
        return true;
      }

 }
 
public static class PhoneUtils
{
    public static void AddPhone(this IServiceCollection services)
    {
        services.AddSingleton<IPhoneService, PhoneService>();
    }
}