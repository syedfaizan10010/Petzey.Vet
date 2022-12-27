using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Domain.Entities
{
    public class Vitals
    {
        public int VitalId { get; set; }
        public string HeartRate { get; set; }
        public double Temperature { get; set; }
        public int AppointmentId { get; set; }
        public int BPM { get; set; }
    }
}
