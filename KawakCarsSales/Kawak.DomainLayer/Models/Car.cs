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
        ///Id of the model of this car (foreign id)
        ///</summary>
        [Required]
        public int IdModel { get; set; }

        ///<summary>
        /// Brand Entity
        ///</summary>
        [Required]
        [ForeignKey("IdModel")] 
        public Model ModelEntity { get; set; }

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
    }
}
