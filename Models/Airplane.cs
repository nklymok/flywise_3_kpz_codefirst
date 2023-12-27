using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWiseBackend.Models
{
    public class Airplane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Passenger> Passengers { get; set; } = null!;
    }
}
