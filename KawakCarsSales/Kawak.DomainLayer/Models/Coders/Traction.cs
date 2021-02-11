using Kavak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Models.Coders
{
    /// <summary>
    /// Traction entity model
    /// </summary>
    public class Traction : Entity
    {
        ///<summary>
        ///Traction name
        ///</summary>
        [Required]
        public string Name { get; set; }
    }
}
