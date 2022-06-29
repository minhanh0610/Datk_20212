﻿using Abp.Application.Services;
using Abp.Domain.Repositories;
using Datk.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.ObjectMapping;
using Newtonsoft.Json.Linq;

namespace Datk.Services
{
    public class ServiceAppService : ApplicationService, IServiceAppService
    {
        private readonly IRepository<Service> _serviceRepository;
        private readonly IObjectMapper _objectMapper;

        public ServiceAppService(IRepository<Service> serviceRepository, IObjectMapper objectMapper)
        {
            _serviceRepository = serviceRepository;
            _objectMapper = objectMapper;
    }

        public async Task CreateService(CreateServiceInput input)
        {
            //We can use Logger, it's defined in ApplicationService class.
            Logger.Info("Creating a service for input: " + input);

            var service = new Service();
            service.TypeSubServiceID = input.TypeSubServiceID;

            if (service.RootServiceID != null)
                service.RootServiceID = input.RootServiceID;

            service.Basic_Information = input.Basic_Information();
            service.Represent_Information = input.Represent_Information();

            await _serviceRepository.InsertAsync(service);

        }

        public async Task DeleteService(int id)
        {
            var service = await _serviceRepository.GetAsync(id);
            if (service != null) await _serviceRepository.DeleteAsync(id);
            else throw new Exception($"Dịch vụ với id { id } không tồn tại");
        }

        public async Task<List<GetServiceOutput>> GetServices(ServiceState state, int? rootServiceId)
        {
            var query = from service in _serviceRepository.GetAll()
                        where service.State == state
                        && service.RootServiceID == rootServiceId
                        select service;
            List<Service> services = query.ToList();

            var result = new List<GetServiceOutput>();
            foreach (var service in services)
            {
                dynamic basicInfo = JObject.Parse(service.Basic_Information);
                dynamic representInfo = JObject.Parse(service.Represent_Information);
                result.Add(new GetServiceOutput()
                {
                    Id = service.Id,
                    State = service.State,
                    Name = basicInfo.name,
                    Address = basicInfo.address,
                    Contact = basicInfo.contact,
                    Name_Represent = representInfo.name_represent,
                    
                });
            }

            return result;
        }

        public async Task UpdateService(UpdateServiceInput input)
        {
            var service = await _serviceRepository.FirstOrDefaultAsync(input.Id);
            if (service == null) throw new Exception($"Cannot find id: {input.Id} ");

            service.State = input.State;

            dynamic basicInfo = JObject.Parse(service.Basic_Information);
            basicInfo.name = input.Name;
            basicInfo.address = input.Address;
            basicInfo.email = input.Email;
            basicInfo.description_Service = input.Description_Service;
            basicInfo.contact = input.Contact;

            service.Basic_Information = basicInfo.ToString();

            await _serviceRepository.UpdateAsync(service);

        }

        public async Task<ViewServiceOutput> ViewService(int id)
        {
            var result = new ViewServiceOutput();
            var service = await _serviceRepository.FirstOrDefaultAsync(id);
            
            result.Id = service.Id;
            result.TypeSubServiceID = service.TypeSubServiceID;
            result.RootServiceID = service.RootServiceID;
            result.CreatedBy = service.CreatedBy;
            result.State = service.State;

            dynamic basicInfo = JObject.Parse(service.Basic_Information);
            result.Name =  basicInfo.name;
            result.Address = basicInfo.address;
            result.Email = basicInfo.email;
            result.Description_Service = basicInfo.description_Service;
            result.Contact = basicInfo.contact;

            dynamic representInfo = JObject.Parse(service.Represent_Information);
            result.Represent = representInfo.represent;
            result.Name_Represent = representInfo.name_represent;
            result.Phone = representInfo.phone;
            result.Email_Represent = representInfo.email_represent;
            result.Cmnd = representInfo.cmnd;
            result.Registration = representInfo.registration;

            return result;
        }
    }
}