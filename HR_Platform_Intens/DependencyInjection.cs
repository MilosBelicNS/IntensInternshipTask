using HR_Platform_Intens.Interfaces;
using HR_Platform_Intens.Interfaces.CandidateSkill;
using HR_Platform_Intens.MappingProfiles;
using HR_Platform_Intens.Repository;
using HR_Platform_Intens.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace HR_Platform_Intens
{
    public static class DependencyInjection
    {
       
        public static void Inject(this IServiceCollection services, IConfiguration configuration)
        {

           
            services.AddAutoMapper(typeof(MappingProfile).Assembly);

            services.AddScoped<ICandidateRepository, CandidateRepository>();

            services.AddScoped<ICandidateService, CandidateService>();

            services.AddScoped<ICandidateSkillRepository, CandidateSkillRepository>();
            services.AddScoped<ICandidateSkillService, CandidateSkillService>();

            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<ISkillService, SkillService>();



        }
    }
}
