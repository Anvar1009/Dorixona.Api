using Dorixona.Application.Abstractions.Messages;
using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.EmployeModel;
using Dorixona.Domain.Models.EmployeModel.DTO;
using Dorixona.Domain.Models.EmployeModel.Proporties;
using Dorixona.Domain.Models.EmployeModel.Repository;
using MediatR;
using System;

namespace Dorixona.Application.Customers.Command.EmployeCommand
{
    internal sealed class DeleteCommandHandle : ICommandHandle<DeleteCommandEmploye, Guid>
    {
        private readonly IEmployeRepository _employeRepository;
        private readonly IUnitOfWork _unitOfWork;


        public DeleteCommandHandle(
            IEmployeRepository employeRepository,
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _employeRepository = employeRepository;
        }
        public async Task<Result<Guid>> Handle(DeleteCommandEmploye request, CancellationToken cancellationToken)
        {
           
                if (request is not null)
                {
                    var result = _employeRepository.CheckId(request.DeleteEmployeDTO.Employe_Id).Result;
                    if (result is not null)
                    {
                        _employeRepository.Delete(result);
                        await _unitOfWork.SaveChangesAsync();
                    }

                     return  Result.Success(request.DeleteEmployeDTO.Employe_Id);
                }
                return Result.Failure<Guid>(EmployeError.EmployeNull);
           
        }
    }
}
