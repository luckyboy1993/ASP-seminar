﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeminarMVC.Models
{
    public class Base
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Ime { get; set; }
    }
}