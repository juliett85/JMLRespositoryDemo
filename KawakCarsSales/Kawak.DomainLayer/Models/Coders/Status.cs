using Kavak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Models.Coders
{
    /// <summary>
    /// Status entity model
    /// </summary>
    public class Status : Entity
    {
        ///<summary>
        ///Status name
        ///</summary>
        [Required]
        public string Name { get; set; }
    }
}
