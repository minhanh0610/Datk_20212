using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datk.Services
{
    public enum ServiceState : byte
    {
        //Chưa duyệt
        Undetermined = 1,

        //Đã duyệt
        Approval = 2,

        //Yêu cầu chỉnh sửa
        Edit = 3,

        //Tạm dừng kinh doanh
        Suspend = 4
        
    }
}
