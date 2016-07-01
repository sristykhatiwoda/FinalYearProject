﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class STU_Student
    {
        public int StudentID{ get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int FacultyId { get; set; }

        public int BatchID { get; set; }

        public int SemesterID { get; set; }


    }
}