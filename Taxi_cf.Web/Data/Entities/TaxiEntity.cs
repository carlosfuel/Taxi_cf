﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Taxi_cf.Web.Data.Entities
{
    public class TaxiEntity
    {
        public int Id { get; set; }

        [StringLength(6, MinimumLength = 6, ErrorMessage = "The {0} field must have {1} characters.")]
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage = "The field {0} must start three characters and ends with three numbers.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Plaque { get; set; }
        
        //Relaciones de la tabla Taxi -------------------------------------------

        public ICollection<TripEntity> Trips { get; set; }

        public ICollection<TripDetailEntity> TripDetails { get; set; }

        public UserEntity User { get; set; }

        //------------------------------------------------------------------------
    }
}
