﻿using System;


namespace StudentAdminPortal.API.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }
        //NAv
        public Guid StudentId { get; set; }
    }
}
