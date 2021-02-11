using Kavak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Models.Coders
{
    /// <summary>
    /// Transmission entity model
    /// </summary>
    public class Transmission : Entity
    {
        ///<summary>
        ///Transmission name
        ///</summary>        
        [Required]
        public string Name { get; set; }
    }
}
