using Dorixona.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Domain.Models.EmployeModel
{
    public static class EmployeError
    {
        public static Error NotFound = new(
       "Employe.NotFound",
       "The Employe with the specified identifier was not found");

        public static Error EmployeNull = new(
            "Employe.Null",
            "It can't create for Employe null");
        public static Error ExistEmployename = new(
            "EmployeName.NotExist",
            "Employename already exist"
            );
        public static Error TryCatchError = new(
           "an error was observed",
           "An error occurred in the employee model, please check again."
           );
    }
}
