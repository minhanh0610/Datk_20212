﻿using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using Datk.People;

using Datk.Services;
using Datk.Tasks;
using Datk.TypeServices;


namespace Datk.EntityFramework
{
    public class DatkDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...
        public virtual IDbSet<Task> Tasks { get; set; }
        public virtual IDbSet<Person> People { get; set; }
        public virtual IDbSet<Service> Service { get; set; }
        public virtual IDbSet<TypeService> TypeService { get; set; }
        public virtual IDbSet<TypeSubService> TypeSubService { get; set; }
        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public DatkDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in DatkDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of DatkDbContext since ABP automatically handles it.
         */
        public DatkDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public DatkDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public DatkDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
