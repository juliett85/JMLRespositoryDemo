using Kavak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Models
{
    /// <summary>
    /// Custumer entity model
    /// </summary>
    public class Costumer : Entity
    {
        ///<summary>
        ///Customer name
        ///</summary>
        [Required]
        public string Name { get; set; }

        ///<summary>
        ///Customer telephone
        ///</summary>
        [Required]
        public string Telephone { get; set; }

        ///<summary>
        ///Customer email
        ///</summary>
        [Required]
        public string Email { get; set; }
    }
}
