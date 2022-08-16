using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datk.Services.Dtos
{
    public class CreateServiceInput
    {
        [Required]
        public int TypeSubServiceID { get; set; }
        public int? RootServiceID { get; set; }

        public ServiceState State { get; set; }

        public int CreatedBy { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }

        //Basic information

        public string Address { get; set; }
        public string Email { get; set; }
        public string Description_Service { get; set; }
        public Array SubService { get; set; }
        public string Doctor { get; set; }
        public string Conclusion { get; set; }
        public string Medicine { get; set; }
        public string ReExam { get; set; }
        public string Basic_Information()
        {
            return "{\"address\": \"" + this.Address +
                "\", \"email\": \"" + this.Email +
                "\", \"desciption_Service\": \"" + this.Description_Service +
                "\", \"doctor\": \"" + this.Doctor +
                "\", \"conclusion\": \"" + this.Conclusion +
                "\", \"medician\": \"" + this.Medicine +
                "\", \"reExam\": \"" + this.ReExam +
                "\", }";

        }

        //Represent information
        public string Represent { get; set; }
        public string Name_Represent { get; set; }
        public string Phone { get; set; }
        public string Email_Represent { get; set; }
        public string Cmnd  { get; set; }
        public string Registration { get; set; }

        //public string Represent_Information { get; set; }
        public string Represent_Information()
        {
            return "{\"represent\": \"" + this.Represent +
                "\", \"name_represent\": \"" + this.Name_Represent +
                "\", \"phone\": \"" + this.Phone +
                "\", \"email_represent\": \"" + this.Email_Represent +
                "\", \"cmnd\": \"" + this.Cmnd +
                "\", \"registration\": \"" + this.Registration +
                "\", }";
        }
        public DateTime CreationTime { get; set; }
    }
}
