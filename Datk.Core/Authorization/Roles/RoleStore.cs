﻿using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Datk.Authorization.Users;


namespace Datk.Authorization.Roles
{
    public class RoleStore : AbpRoleStore<Role, User>
    {
        public RoleStore(
            IRepository<Role> roleRepository,
            IRepository<UserRole, long> userRoleRepository,
            IRepository<RolePermissionSetting, long> rolePermissionSettingRepository,
            IUnitOfWorkManager unitOfWorkManager)
            : base(
                roleRepository,
                userRoleRepository,
                rolePermissionSettingRepository,
                unitOfWorkManager)
        {
        }
    }
}
