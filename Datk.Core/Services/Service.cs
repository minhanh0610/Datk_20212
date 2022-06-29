using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datk.Services
{
    public class Service : Entity
    {

        public virtual int TypeSubServiceID { get; set; }
        public virtual int? RootServiceID { get; set; }
        public virtual int? CreatedBy { get; set; }
        public virtual string Basic_Information { get; set; }
        public virtual string Represent_Information { get; set; }

        public virtual DateTime CreationTime { get; set; }
        public virtual ServiceState State { get; set; }

        public Service()
        {
            CreationTime = DateTime.Now;
            State = ServiceState.Undetermined;
        }
    }
}
