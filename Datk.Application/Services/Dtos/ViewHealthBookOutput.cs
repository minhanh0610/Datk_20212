using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datk.Services.Dtos
{
    public class ViewHealthBookOutput
    {
        public int Id { get; set; }
        public int TypeSubServiceID { get; set; }
        public int? RootServiceID { get; set; }
        public int? CreatedBy { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Doctor { get; set; }
        public string Conclusion { get; set; }
        public Array Medicine { get; set; }
        public DateTime ReExam { get; set; }


    }
}
