using Abp.Hangfire;
using Abp.Hangfire.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Boxfusion.Membership.Web.Host.Startup
{
    [DependsOn(typeof(MembershipWebCoreModule),
        typeof(AbpHangfireAspNetCoreModule))]
    public class SheshaWebHostModule: AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SheshaWebHostModule).GetAssembly());
        }
        public override void PreInitialize()
        {
            Configuration.BackgroundJobs.UseHangfire();
        }
    }
}
