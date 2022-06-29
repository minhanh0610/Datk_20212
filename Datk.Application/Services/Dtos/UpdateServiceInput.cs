using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datk.Services.Dtos
{
    public class UpdateServiceInput
    {
        public int Id { get; set; }

        public ServiceState State { get; set; }

        //Basic information
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Description_Service { get; set; }
        public string Contact { get; set; }

    }
}
