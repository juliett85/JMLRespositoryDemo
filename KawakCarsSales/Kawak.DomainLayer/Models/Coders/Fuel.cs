using Kavak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Models.Coders
{
    /// <summary>
    /// Fuel entity model
    /// </summary>
    public class Fuel : Entity
    {
        ///<summary>
        ///Fuel type
        ///</summary>
        [Required]
        public string Type { get; set; }
    }
}
