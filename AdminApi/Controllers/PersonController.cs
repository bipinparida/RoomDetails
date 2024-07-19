using AdminApi.DTO.App.PersonsDTO;
using AdminApi.Models;
using AdminApi.Models.App.Persons;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Person> _PersonRepo;
        public PersonController(IConfiguration config,
                               AppDbContext context,
                               ISqlRepository<Person> personRepo)
        {
            _config = config;
            _context = context;
            _PersonRepo = personRepo;
        }

        ///<summary>
        ///Create Student
        ///</summary>
        [HttpPost]
        public IActionResult PersonCreate(CreatePersonDTO createPersonDTO)
        {
            var objcheck = _context.Persons.SingleOrDefault(opt => opt.MobileNo == createPersonDTO.MobileNo && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    Person person = new Person();

                    person.PersonName = createPersonDTO.PersonName;
                    person.MobileNo = createPersonDTO.MobileNo;
                   // person.StudentName = createPersonDTO.StudentName;
                   
                   

                    person.CreatedBy = createPersonDTO.CreatedBy;
                    person.CreatedOn = System.DateTime.Now;
                    var obj = _PersonRepo.Insert(person);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Mobile Number..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

    }
}
