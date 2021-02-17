using Kavak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Models
{
    /// <summary>
    /// Model entity model
    /// </summary>
    public class Model : EntityBase
    {
        ///<summary>
        ///Id of the brand of this model (foreign id)
        ///</summary>
        [Required]
        public int IdBrand { get; set; }

        ///<summary>
        /// Brand Entity
        ///</summary>
        [Required]
        [ForeignKey("IdBrand")]
        public Brand BrandEntity { get; set; }
    }
}
