using Kavak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Models.Coders
{
    /// <summary>
    /// Doors entity model 
    /// </summary>
    public class Doors : Entity
    {
        ///<summary>
        ///Amount of doors of this version
        ///</summary>
        [Required]
        public int Amount { get; set; }
    }
}
