using HR_Platform_Intens.Models;

using System.Collections.Generic;

namespace HR_Platform_Intens.Interfaces
{
    public interface ICandidateRepository
    {
        IEnumerable<Candidate> GetAll(string name, int? skillId);
        Candidate GetById(int id);
        void Create(Candidate candidate);
        void Delete(int id);
        
    }
}
