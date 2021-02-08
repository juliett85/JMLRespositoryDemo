using Kawak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kawak.DomainLayer.Models
{
    /// <summary>
    /// Brand entity model
    /// </summary>
    public class Brand : Entity
    {
        /// <summary>
        /// Brand name
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
