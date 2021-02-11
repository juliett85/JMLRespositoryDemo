using Kavak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Models
{
    /// <summary>
    /// Year entity model
    /// </summary>
    public class Year : Entity
    {
        ///<summary>
        ///Year name
        ///</summary>
        [Required]
        public string Name { get; set; }
    }
}
