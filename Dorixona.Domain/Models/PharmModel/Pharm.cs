using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.OrderModel;
using Dorixona.Domain.Models.OrderModel.Proporties;
using Dorixona.Domain.Models.PharmModel.Proporties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.Domain.Models.PharmModel
{
    public sealed class Pharm : Entity
    {

        private Pharm(Guid id, PharmDTO pharmDTO) : base(id)
        {
            PharmId = pharmDTO.PharmId;
            PharmAddress = pharmDTO.PharmAddress;   
            PharmName = pharmDTO.PharmName;
            PharmPhoneNumber = pharmDTO.PharmPhoneNumber;
        }
        protected Pharm() { }
        public PharmId PharmId { get; set; }
        public PharmName PharmName { get; set; }   
        public PharmAddress PharmAddress {  get; set; }
        public PharmPhoneNumber PharmPhoneNumber {  get; set; }
        public static Pharm CreateOrder(Guid Id, PharmDTO pharm)
        {
            return new Pharm(Id, pharm);
        }

    }
}
