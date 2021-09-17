using AutoMapper;
using HR_Platform_Intens.DTO;
using HR_Platform_Intens.Interfaces;
using HR_Platform_Intens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Platform_Intens.Services
{
    public class CandidateServceFake : ICandidateService
    {
        private  List<Candidate> _candidates;
        private IMapper mapper;

       
        public CandidateServceFake(IMapper mapper)
        {
            _candidates = new List<Candidate>()
            {
                new Candidate() {
                    Id = 1,
                    FullName = "Pera Peric",
                    BirthDate=new DateTime(1995, 11, 29),
                    ContractNumber = 1, Email = "pera@mail" 
                },

                new Candidate() {
                    Id = 2,
                    FullName = "Mita Mitic",
                    BirthDate=new DateTime(1994, 1, 19),
                    ContractNumber = 2,
                    Email = "mita@mail",
                    
                   },

                new Candidate() { 
                    Id = 3, 
                    FullName = "Zika Zikic", 
                    BirthDate=new DateTime(1998, 10, 06), 
                    ContractNumber = 3, 
                    Email = "zika@mail",
                   

                },
            };
            this.mapper = mapper;
        }
        public IEnumerable<CandidateResponse> GetAll(string name, int? skillId)
        {
            //let's say the parameters are null
            var candidates = _candidates;

            return mapper.Map<List<CandidateResponse>>(candidates).AsEnumerable();
        }
        public void Create(CandidateRequest candidateRequest)
        {
            candidateRequest.FullName = "Mile Milic";
            candidateRequest.BirthDate = new DateTime(1996, 12, 21);
            candidateRequest.ContractNumber = 4;
            candidateRequest.Email = "milo@mail.com";

            Candidate candidate = mapper.Map<Candidate>(candidateRequest);
            candidate.Id = 4;

            _candidates.ToList().Add(candidate);
        }
        public CandidateResponse GetById(int id)
        {
            var candidate =  _candidates.Where(a => a.Id == id)
                                        .FirstOrDefault();
            return mapper.Map<CandidateResponse>(candidate);
        }
        public void Delete(int id)
        {
            var existing = _candidates.First(a => a.Id == id);
            _candidates.ToList().Remove(existing);
        }
    }
}
