﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReader.Data.Models
{
    public class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalCode { get; set; }
        public string Pic { get; set; }
        public string Phone { get; set; }
        public int GenderType{ get; set; }
        public int JobType { get; set; }
        public int IsAcceptRules { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
