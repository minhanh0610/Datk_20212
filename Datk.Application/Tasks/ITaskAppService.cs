using Abp.Application.Services;
using Datk.Tasks.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Datk.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        /*[HttpGet]
        GetTasksOutput GetTasks(GetTasksInput input);

        [HttpPut]
        void UpdateTask(UpdateTaskInput input);

        [HttpPost]
        void CreateTask(CreateTaskInput input);*/

        [HttpGet]
        string Test();
    }
}
