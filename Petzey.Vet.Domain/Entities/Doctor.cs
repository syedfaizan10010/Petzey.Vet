using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Domain.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NPINumber { get; set; }
        public string Speciality { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Clinic { get; set; }
        public bool Image { get; set; }
    }
}
