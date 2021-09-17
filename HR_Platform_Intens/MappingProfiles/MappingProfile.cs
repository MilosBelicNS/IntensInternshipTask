using AutoMapper;
using HR_Platform_Intens.DTO;
using HR_Platform_Intens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Platform_Intens.MappingProfiles
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Candidate, CandidateResponse>();
            CreateMap<CandidateRequest, Candidate>();

            CreateMap<Skill, SkillResponse>();
            CreateMap<SkillRequest, Skill>();

            CreateMap<CandidateSkill, CandidateSkillResponse>();
        }
    }
}
