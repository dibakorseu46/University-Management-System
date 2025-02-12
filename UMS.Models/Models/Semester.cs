﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.Models.Models
{
    public class Semester
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9 ]+$")]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Batch { get; set; }
        public IEnumerable<PreregistrationCourses> PreregistrationCourses { get; set; }
        public IEnumerable<AssignRegistrationCourse> AssignRegistrationCourses { get; set; }
        public IEnumerable<StudentDetails> StudentDetails { get; set; }
        
        
    }
}
