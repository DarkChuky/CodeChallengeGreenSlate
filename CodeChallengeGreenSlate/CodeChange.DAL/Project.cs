﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenge.DAL
{
    public class Project
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Credits { get; set; }
    }
}
