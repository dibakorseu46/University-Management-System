﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.Models.Models
{
    public class Day
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z ]+$")]
        public string Name { get; set; }
    }
}
