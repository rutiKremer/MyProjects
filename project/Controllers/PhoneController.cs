using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PROJECT.Interfaces;
using PROJECT.Models;
namespace project.Controllers;

[ApiController]
[Route("[controller]")]
public class PhoneController : ControllerBase
{
    IPhoneService PhoneService;

    public PhoneController(IPhoneService phoneService)
    {
        this.PhoneService = phoneService;
    }

    [HttpGet]
    [Authorize(Policy = "User")]

     public ActionResult<List<Phone>> Get()
    {
        return PhoneService.GetAll(int.Parse(User.FindFirst("id")?.Value!));
    }

    [HttpGet("{id}")]
    [Authorize(Policy = "User")]

    public ActionResult<Phone> Get(int id)
    {
        var phone = PhoneService.GetById(id);
        if (phone == null)
            return NotFound();
        return phone;
    }

    [HttpPost]
    [Authorize(Policy = "User")]

    public ActionResult Post(Phone newPhone)
    {
        var newId = PhoneService.Add(newPhone,int.Parse(User.FindFirst("id")?.Value!));
        return CreatedAtAction("Post",new { id = newId}, PhoneService.GetById(newId));
    }

    [HttpPut("{id}")]
    [Authorize(Policy = "User")]

    public ActionResult Put(int id, Phone newPhone)
    {
        System.Console.WriteLine("hgil");
        var result = PhoneService.Update(id, newPhone,int.Parse(User.FindFirst("id")?.Value!));
        if (!result)
        {
            return BadRequest();
        }
        return NoContent();
    }

    [HttpDelete("{id}")]
    [Authorize(Policy = "User")]

    public ActionResult Delete(int id)
    {
        bool result = PhoneService.Delete(id);
        if (!result)
            return NotFound();
        return NoContent();
    }
}


   

   
  

   

    

