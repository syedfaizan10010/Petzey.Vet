using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Domain.Entities
{
    public class Test
    {
        public int TestId { get; set; }
        public DateOnly Date { get; set; }
        public string Description { get; set; }
        public int AppointmentId { get; set; }
    }
}
