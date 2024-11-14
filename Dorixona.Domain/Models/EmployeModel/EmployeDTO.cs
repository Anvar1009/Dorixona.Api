using Dorixona.Domain.Models.EmployeModel.Proporties;
using Dorixona.Domain.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Domain.Models.EmployeModel
{
    public class EmployeDTO
    {
        public FirstName FirstName { get; set; }
        public LastName LastName { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Email Email { get; set; }
        public DateOfBirth DateOfBirth { get; set; }
        public Salary Salary { get; set; }

       
    }
}
