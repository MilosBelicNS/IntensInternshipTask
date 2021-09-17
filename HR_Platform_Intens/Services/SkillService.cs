using AutoMapper;
using HR_Platform_Intens.DTO;
using HR_Platform_Intens.Interfaces;
using HR_Platform_Intens.Models;


namespace HR_Platform_Intens.Services
{
    public class SkillService : ISkillService
    {

        private ISkillRepository repository;
        private IMapper mapper { get; set; }
        public SkillService(ISkillRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;

        }

        public void Create(SkillRequest skillRequest)
        {
            Skill skill = mapper.Map<Skill>(skillRequest);
            repository.Create(skill);
        }
    }
}
