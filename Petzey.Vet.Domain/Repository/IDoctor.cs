using Petzey.Vet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Domain.Repository
{
    public interface IDoctor
    {
        //Retrieveing Vet by Id
         Doctor GetVetById(int id);
        //Get vet by name
        List<Doctor> GetVetByName(string name);    

        //Adding Doctor
        void AddVet(Doctor vet);


        void UpdateVet( Doctor vet);    
        void DeleteVet(int id);

        //Get All Vets
        List<Doctor> GetAllVet();
    }
}
