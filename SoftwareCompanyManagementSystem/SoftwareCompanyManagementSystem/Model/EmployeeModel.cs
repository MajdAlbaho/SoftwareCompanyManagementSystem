using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareCompanyManagementSystem.Model
{
    public class EmployeeModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public byte[] PersonalPhoto { get; set; }
        public int ExperinceYear { get; set; }
        public Guid UserId { get; set; }
        public int EducationDegreeId { get; set; }

        public string EducationDegreeName { get; set; }
        public int UserRoleId { get; set; }
    }
}
