using Dorixona.Application.Abstractions.Messages;
using Dorixona.Domain.Models.EmployeModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Application.Customers.Command.EmployeCommand
{
    public record UpdateCommandEmploye(UpdateEmployeDTO UpdateEmployeDTO) : ICommand<Guid>;

}
