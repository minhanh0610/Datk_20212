using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datk.TypeServices
{
    public class TypeService : Entity
    {
        public virtual string Type { get; set; }
        public virtual string Description { get; set; }
    }
}
