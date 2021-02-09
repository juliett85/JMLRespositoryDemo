using Kawak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kawak.DomainLayer.Models
{
    /// <summary>
    /// Car entity model
    /// </summary>
    public class Car : Entity
    {
        ///<summary>
        ///Id of the version of this car (foreign id)
        ///</summary>
        [Required]
        public int IdVersion { get; set; }

        ///<summary>
        /// Version Entity
        ///</summary>
        [Required]
        [ForeignKey("IdVersion")] 
        public Version VersionEntity { get; set; }

        ///<summary>
        ///Id of the status of the car (foreign key)
        ///</summary>
        [Required]
        public int IdStatus { get; set; }

        ///<summary>
        ///Status Entity
        ///</summary>
        [Required]
        [ForeignKey("IdStatus")] 
        public Status StatusEntity { get; set; } 

        ///<summary>
        /// Car price
        ///</summary>
        [Required]
        public double Price { get; set; }

        ///<summary>
        ///Car Mileage 
        ///</summary>
        [Required]
        public double Mileage { get; set; }

        ///<summary>
        ///Car location
        ///</summary>
        [Required]
        public string Location { get; set; }

        ///<summary>
        ///Car color
        ///</summary>
        public string Color { get; set; }
    }
}
