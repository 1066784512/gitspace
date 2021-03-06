﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Lxk.Core;
using Lxk.Core.Authorization;

namespace Lxk.Ucenter.Application
{
    [DependsOn(
        typeof(LxkCoreModule),
        typeof(AbpAutoMapperModule))]
    public class ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LxkAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
