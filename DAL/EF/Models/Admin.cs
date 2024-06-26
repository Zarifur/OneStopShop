﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Admin
    {
        [Key]
        [ForeignKey("User")]
        public int UId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Gender { get; set; }
        //public string PhoneNumber { get; set; }
        //public string Address { get; set; }
        //public int AccNumber { get; set; }
        //public string ProfilePicture { get; set; }

        public virtual User User { get; set; }
    }
}
