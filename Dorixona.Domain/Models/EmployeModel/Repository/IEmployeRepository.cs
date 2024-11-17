using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Domain.Models.EmployeModel.Repository
{
    public interface IEmployeRepository
    {
        void Add(Employe employe);  

        void Update(Employe employe);

        void Delete(Employe employe);   

        Task<Employe> CheckId(Guid employe);

    }
}
