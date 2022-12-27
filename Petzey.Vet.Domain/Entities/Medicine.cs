using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Domain.Entities
{
    public class Medicine
    {

        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public int NoOfDays { get; set; }
        public bool Dosage { get; set; }
        public string Comments { get; set; }
    }
    
    
}
