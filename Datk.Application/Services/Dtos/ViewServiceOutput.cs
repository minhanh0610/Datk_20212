using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datk.Services.Dtos
{
    public class ViewServiceOutput
    {
        public int Id { get; set; }
        public int TypeSubServiceID { get; set; }
        public int? RootServiceID { get; set; }
        public int? CreatedBy { get; set; }
        //Basic information
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Description_Service { get; set; }
        public string Contact { get; set; }
        //public string Basic_Information { get; set; }
        //Represent information
        public string Represent { get; set; }
        public string Name_Represent { get; set; }
        public string Phone { get; set; }
        public string Email_Represent { get; set; }
        public string Cmnd { get; set; }
        public string Registration { get; set; }
        //public string Represent_Information { get; set; }

        public DateTime CreationTime { get; set; }
        public ServiceState State { get; set; }
    }
}
