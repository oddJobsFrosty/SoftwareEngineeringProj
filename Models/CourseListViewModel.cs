﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBlogDemo2.Models
{
    public class CourseListViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public string ProfessorName { get; set; }

    }
}
