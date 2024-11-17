using Dorixona.Application.Abstractions.Messages;
using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.EmployeModel;
using Dorixona.Domain.Models.EmployeModel.DTO;
using Dorixona.Domain.Models.EmployeModel.Proporties;
using Dorixona.Domain.Models.EmployeModel.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Application.Customers.Command.EmployeCommand
{
    internal sealed class UpdateCommandHandle : ICommandHandle<UpdateCommandEmploye, Guid>
    {
        private readonly IEmployeRepository _employeRepository;
        private readonly IUnitOfWork _unitOfWork;


        public UpdateCommandHandle(
            IEmployeRepository employeRepository,
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _employeRepository = employeRepository;
        }
        public async Task<Result<Guid>> Handle(UpdateCommandEmploye request, CancellationToken cancellationToken)
        {

            try
            {
                if (request is not null)
                {
                    var empId = request.UpdateEmployeDTO.Id;

                    var employeDTO = new EmployeDTO
                    {
                        FirstName = new FirstName(request.UpdateEmployeDTO.FirstName),
                        LastName = new LastName(request.UpdateEmployeDTO.LastName),
                        Salary = new Salary(request.UpdateEmployeDTO.Salary),
                        DateOfBirth = new DateOfBirth(request.UpdateEmployeDTO.DateOfBirth),
                        Email = new Email(request.UpdateEmployeDTO.Email),
                        PhoneNumber = new PhoneNumber(request.UpdateEmployeDTO.PhoneNumber),
                        PharmId = new PharmId(Guid.NewGuid()),
                    };

                    var model = Employe.CreateEmployeModel(empId, employeDTO);
                    _employeRepository.Update(model);
                    await _unitOfWork.SaveChangesAsync();

                    return Result.Success(empId);
                }
                return Result.Failure<Guid>(EmployeError.EmployeNull);
            }
            catch
            {
                return Result.Failure<Guid>(EmployeError.TryCatchError);
            }
        }
    }
}
