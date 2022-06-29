using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datk.Tasks
{
     public enum TaskState : byte
    {
        Active = 1,

        /// <summary>   
        /// The task is completed.
        /// </summary>
        Completed = 2
    }
}
