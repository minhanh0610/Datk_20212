using Abp.Application.Services;
using Datk.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Datk.Services
{
    public interface IServiceAppService : IApplicationService
    {
        [HttpGet]
        Task<List<GetServiceOutput>> GetServices(ServiceState state,  int typeSubServiceId);

        [HttpPost]
        Task CreateService(CreateServiceInput input);

        [HttpGet]
        Task<ViewServiceOutput> ViewService(int id);

        [HttpPut]
        Task UpdateService(UpdateServiceInput input);

        [HttpDelete]
        Task DeleteService(int id);

        [HttpGet]
        Task<List<GetServiceOutput>> SearchService(string sortBy, int? rootServiceId, int typeSubServiceId);

    }
}
