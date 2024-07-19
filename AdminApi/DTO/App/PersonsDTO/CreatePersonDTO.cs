using System;

namespace AdminApi.DTO.App.PersonsDTO
{
    public class CreatePersonDTO
    {
        public string PersonName { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? DOB { get; set; }
        public string Gender { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string Address { get; set; }
        public string PersonImage { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdatePersonDTO
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? DOB { get; set; }
        public string Gender { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string Address { get; set; }
        public string PersonImage { get; set; }
        public bool IsActive { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
