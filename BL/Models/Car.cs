using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Car
    {
        public int Id { get; set; }
    
        public string CarNumber { get; set; }
        public string CarOwner { get; set; }
        public string CarModel { get; set; }
        public string CarImagePath { get; set; }
        public int AvailableSeats { get; set; }

        [ForeignKey("CarOwner")]
        public virtual ApplicationUser Owner { get; set; }
    }
}
