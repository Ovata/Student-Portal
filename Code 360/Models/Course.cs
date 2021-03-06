﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Code_360.Models.Course
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Level Level { get; set; }

        public IList<ProgrammeCourse> ProgrammeCourses { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
