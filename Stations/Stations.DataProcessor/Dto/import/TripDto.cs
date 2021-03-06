﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Stations.DataProcessor.Dto.import
{
    public class TripDto
    {
        [Required]
        [MaxLength(10)]
        public string Train { get; set; }

        [Required]
        [MaxLength(50)]
        public string OriginStation { get; set; }

        [Required]
        [MaxLength(50)]
        public string DestinationStation { get; set; }

        [Required]
        public string DepartureTime { get; set; }

        [Required]
        public string ArrivalTime { get; set; }

        public string Status { get; set; } = "OnTime";

        public TimeSpan? TimeDifference { get; set; }
    }
}
