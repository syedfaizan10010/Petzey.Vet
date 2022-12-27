using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Domain.Entities
{
    public class Symptoms
    {
        public int SymptomId { get; set; }
        public int AppointmentId { get; set; }
    }
}
