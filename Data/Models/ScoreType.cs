﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookReader.Data.Models
{
    public class ScoreType
    {
        public int Id { get; set; }
        [ForeignKey("1")]
        public int AdminId { get; set; }
        public string Title { get; set; }
        public int ScoreValue { get; set; }
        public bool IsActive { get; set; }
        public int ActionType { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal MinAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public User Admin { get; set; }
    }
}
