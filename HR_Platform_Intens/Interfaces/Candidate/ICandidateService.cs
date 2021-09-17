using HR_Platform_Intens.DTO;
using HR_Platform_Intens.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace HR_Platform_Intens.Interfaces
{
   public interface ICandidateService
    {
        IEnumerable<CandidateResponse> GetAll(string name, int? skillId);
        CandidateResponse GetById(int id);
        void Create(CandidateRequest candidateRequest);
        void Delete(int id);
    }
}
