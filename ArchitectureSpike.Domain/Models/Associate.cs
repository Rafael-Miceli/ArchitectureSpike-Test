﻿using System;

namespace ArchitectureSpike.Domain.Models
{
    public class Associate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string Title { get; set; }
    }
 }
