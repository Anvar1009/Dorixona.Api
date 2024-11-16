using Dorixona.Application.Abstractions.Messages;
using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.EmployeModel;
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
                    var userDetails = await ..Users.FirstOrDefaultAsync(x => x.UserID == request.UserID);
                    if (userDetails != null)
                    {
                        userDetails.FirstName = request.FirstName;
                        userDetails.LastName = request.LastName;
                        userDetails.Email = request.Email;
                        userDetails.Department = request.Department;
                        userDetails.Password = request.Password;

                        await demoDBContext.SaveChangesAsync();
                        response = new ResponseDto(userDetails.UserID, "Updated Successfully!");
                        mediator.Publish(new ResponseEvent(response));
                        return response;
                    }
                    else
                    {
                        response = new ResponseDto(request.UserID, "User ID not found in the Database!");
                        mediator.Publish(new ErrorEvent(response));
                        return response;
                    }
                }
                return Result.Failure<Guid>(EmployeError.EmployeNull);
            }
            catch
            {
                response = new ResponseDto(default, "Failed!");
                mediator.Publish(new ErrorEvent(response));
                return response;
            }
        }
    }
}
