using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datk.Services.Dtos
{
    public class GetServiceOutput
    {
        public int Id { get; set; }
        public ServiceState State { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Name_Represent { get; set; }
        public string Contact { get; set; }


    }
}
