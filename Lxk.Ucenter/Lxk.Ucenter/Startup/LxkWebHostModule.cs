using Abp.Modules;
using Abp.Reflection.Extensions;
using Lxk.Ucenter.Web.Core;
using Lxk.Ucenter.Web.Core.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Lxk.Ucenter.Web.Host.Startup
{
    [DependsOn(
        typeof(WebCoreModule))]
    public class LxkWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LxkWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LxkWebHostModule).GetAssembly());
        }
    }
}
