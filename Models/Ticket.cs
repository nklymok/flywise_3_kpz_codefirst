using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWiseBackend.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Passenger Passenger { get; set; }
        public Airplane Airplane { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public double Price { get; set; }
    }
}
