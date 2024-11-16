using Dorixona.Application.Abstractions.Messages;
using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.EmployeModel;
using Dorixona.Domain.Models.EmployeModel.DTO;
using Dorixona.Domain.Models.EmployeModel.Proporties;
using Dorixona.Domain.Models.EmployeModel.Repository;
using Dorixona.Domain.Models.OrderModel.OrderRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Application.Customers.Command.EmployeCommand
{
    internal sealed class CreateCommandHandle : ICommandHandle<CreateCommandEmploye, Guid>
    {
        private readonly IEmployeRepository _employeRepository;
        private readonly IUnitOfWork _unitOfWork;


        public CreateCommandHandle(
            IEmployeRepository  employeRepository,
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _employeRepository = employeRepository;
        }
        public async Task<Result<Guid>> Handle(CreateCommandEmploye request, CancellationToken cancellationToken)
        {
            if (request == null)
                return Result.Failure<Guid>(EmployeError.EmployeNull);

            Guid employeId = Guid.NewGuid();   
            
            var EmployemodelDTO = new EmployeDTO
            {
                FirstName= new FirstName(request.CreateEmployeDTO.FirstName),
                LastName = new LastName(request.CreateEmployeDTO.LastName), 
                Salary= new Salary(request.CreateEmployeDTO.Salary),    
                DateOfBirth = new DateOfBirth(request.CreateEmployeDTO.DateOfBirth),
                Email = new Email(request.CreateEmployeDTO.Email),
                PhoneNumber=new PhoneNumber(request.CreateEmployeDTO.PhoneNumber),
                PharmId = new PharmId(Guid.NewGuid()),
            };


            var employe = Employe.CreateEmployeModel(employeId, EmployemodelDTO);

            _employeRepository.Add(employe);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success(employeId);
        }
    }
}
