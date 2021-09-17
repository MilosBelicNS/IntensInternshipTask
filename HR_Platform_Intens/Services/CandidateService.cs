using AutoMapper;
using HR_Platform_Intens.DTO;
using HR_Platform_Intens.Interfaces;
using HR_Platform_Intens.Models;
using System.Collections.Generic;
using System.Linq;

namespace HR_Platform_Intens.Services
{
    public class CandidateService : ICandidateService
    {
        private  ICandidateRepository repository;
        
        private IMapper mapper { get; set; }
        public CandidateService(ICandidateRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
            
            
        }
        
        public IEnumerable<CandidateResponse> GetAll(string name, int? skillId)
        {
            var candidates = repository.GetAll(name, skillId);


            return mapper.Map<IEnumerable<CandidateResponse>>(candidates);
            
        }

        public CandidateResponse GetById(int id)
        {
            var candidate = repository.GetById(id);

            return mapper.Map<CandidateResponse>(candidate);
        }

        public void Create(CandidateRequest candidateRequest)
        {

            Candidate candidate = mapper.Map<Candidate>(candidateRequest);
            repository.Create(candidate);
        }

        

        public void Delete(int id)
        {
             repository.Delete(id);
            
        }
    }
}
