﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Stations.Models;

namespace Stations.DataProcessor.Dto.import
{
    public class TrainDto
    {
        [Required]
        [MaxLength(10)] 
        public string TrainNumber { get; set; }

        public string Type { get; set; } = "HighSpeed";


        public List<SeatDto> Seats { get; set; } =  new List<SeatDto>();

    }
}