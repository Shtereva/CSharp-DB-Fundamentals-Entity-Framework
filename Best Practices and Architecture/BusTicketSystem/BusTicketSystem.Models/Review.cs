﻿using System;
using System.Collections.Generic;

namespace BusTicketSystem.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public double Grade { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime? PublishingDateTime { get; set; }

        public int BusCompanyId { get; set; }
        public BusCompany BusCompany { get; set; }

    }
}