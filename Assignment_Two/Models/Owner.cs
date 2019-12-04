using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Two.Models
{
    public class Owner
    {
        [Key]
        public int OwnerID { get; set; }

        [ForeignKey("TeamID")]
        public int TeamID { get; set; }

        public string OwnerName { get; set; }

        public string CurrentTeam { get; set; }
    }
}


