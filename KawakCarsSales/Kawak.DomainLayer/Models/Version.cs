using Kawak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kawak.DomainLayer.Models
{
    /// <summary>
    /// Version entity model 
    /// </summary>
    public class Version : Entity
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
        ///Version name 
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        ///Amount of car gates of this version 
        ///</summary>
        public int GateAmount { get; set; }

        ///<summary>
        ///Car traction of this version 
        ///</summary>
        public string Traction { get; set; }

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
