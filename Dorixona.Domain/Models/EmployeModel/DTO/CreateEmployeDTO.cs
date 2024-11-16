using Dorixona.Domain.Models.EmployeModel.Proporties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Domain.Models.EmployeModel.DTO
{
    public class CreateEmployeDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Salary { get; set; }

    }
}
