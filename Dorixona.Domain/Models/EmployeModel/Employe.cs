using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.OrderModel.Proporties;
using Dorixona.Domain.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dorixona.Domain.Models.EmployeModel.Proporties;
using Dorixona.Domain.Models.EmployeModel.DTO;

namespace Dorixona.Domain.Models.EmployeModel
{
    public sealed class Employe:Entity
    {
        private Employe(Guid Id, EmployeDTO employeDTO) : base(Id)
        {
           
            FirstName = employeDTO.FirstName;
            LastName = employeDTO.LastName;
            PhoneNumber = employeDTO.PhoneNumber;
            Email = employeDTO.Email; 
            DateOfBirth = employeDTO.DateOfBirth;
            Salary = employeDTO.Salary;
            PharmId = employeDTO.PharmId;

        }
        public Employe() { }

        public FirstName  FirstName { get; set; }
        public LastName LastName { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Email Email { get; set; }
        public DateOfBirth DateOfBirth { get; set; }
        public Salary  Salary { get; set; }
        public PharmId PharmId { get; set; }

        public static Employe CreateEmployeModel(Guid Id, EmployeDTO employeDTO)
        {
            return new Employe(Id, employeDTO);
        }

    }
}
