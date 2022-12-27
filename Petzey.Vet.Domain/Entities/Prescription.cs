using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Domain.Entities
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }

        public int AppointmentId { get; set; }
        public int MedicineId { get; set; }
    }
}
