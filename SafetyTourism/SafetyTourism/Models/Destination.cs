﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyTourism.Models
{
    public class Destination
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        [ForeignKey("Country")]
        [Display(Name = "Country")]
        public Country Country;
    }
}
