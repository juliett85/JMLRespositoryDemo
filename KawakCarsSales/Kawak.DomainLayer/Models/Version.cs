using Kavak.DomainLayer.Entities.Base;
using Kavak.DomainLayer.Models.Coders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Models
{
    /// <summary>
    /// Version entity model 
    /// </summary>
    public class Version : EntityBase
    {
        ///<summary>
        /// Id of the transmision of this version (foreign key)
        ///</summary>
        [Required]
        public int IdTransmission { get; set; }

        ///<summary>
        /// Transmission Entity
        ///</summary>
        [Required]
        [ForeignKey("IdTransmission")]
        public Transmission TransmissionEntity { get; set; }

        ///<summary>
        /// Id of the doors amount of this version (foreign key)
        ///</summary>
        [Required]
        public int IdDoors { get; set; }

        ///<summary>
        /// Doors Entity
        ///</summary>
        [Required]
        [ForeignKey("IdDoors")]
        public Doors DoorsEntity { get; set; }

        ///<summary>
        /// Id of the traction of this version (foreign key)
        ///</summary>
        [Required]
        public int IdTraction { get; set; }

        ///<summary>
        /// Traction Entity
        ///</summary>
        [Required]
        [ForeignKey("IdTraction")]
        public Traction TractionEntity { get; set; }

        ///<summary>
        /// Id of the fuel of this version (foreign key)
        ///</summary>
        [Required]
        public int IdFuel { get; set; }

        ///<summary>
        /// Fuel Entity
        ///</summary>
        [Required]
        [ForeignKey("IdFuel")]
        public Fuel FuelEntity { get; set; }

        ///<summary>
        ///Type of car seats of this version 
        ///</summary>
        public string SeatsType { get; set; }

        ///<summary>
        ///Car wheels of this version 
        ///</summary>
        public int Wheels { get; set; }

        ///<summary>
        ///If this car version has turbo
        ///</summary>
        public bool Turbo { get; set; }

        ///<summary>
        ///Car cylinder of this version 
        ///</summary>
        public string Cylinder { get; set; }

        ///<summary>
        ///Amount of liters per kilometer of this version 
        ///</summary>
        public double Liters { get; set; }

        ///<summary>
        ///Amount of car horsepower of this version
        ///</summary>
        public int Horsepower { get; set; }

    }
}
