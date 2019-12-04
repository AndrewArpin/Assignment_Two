using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Two.Models
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
                
        public string TeamName { get; set; }

        public string TeamCity { get; set; }

        public string StadiumName { get; set; }

        public ICollection<Owner> Owners { get; set; }
    }
}
