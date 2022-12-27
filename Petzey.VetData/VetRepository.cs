
using Petzey.Vet.Domain.Repository;

namespace Petzey.Vet.Data
{
    public class VetRepository : IDoctor
    {
        VetDbcontext db = new VetDbcontext();
        public void AddVet(Domain.Entities.Doctor vet)
        {
            throw new NotImplementedException();
        }

        public void DeleteVet(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Doctor> GetAllVet()
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Doctor GetVetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Doctor> GetVetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateVet(Domain.Entities.Doctor vet)
        {
            throw new NotImplementedException();
        }
    }
}
