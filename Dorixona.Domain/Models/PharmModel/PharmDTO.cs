using Dorixona.Domain.Models.OrderModel.Proporties;
using Dorixona.Domain.Models.PharmModel.Proporties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Domain.Models.PharmModel
{
    public class PharmDTO
    {
        public PharmId PharmId { get; set; }
        public PharmAddress PharmAddress { get; set; }
        public PharmPhoneNumber PharmPhoneNumber { get; set; }
        public PharmName PharmName { get; set; }
       
    }
}
