using Kavak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Models
{
    /// <summary>
    /// Entity model of relationship between year entity and model entity
    /// </summary>
    public class YearModel : Entity
    {
        ///<summary>
        /// Id of year of this model (foreign key)
        ///</summary>
        [Required]
        public int IdYear { get; set; }

        ///<summary>
        /// Year Entity
        ///</summary>
        [Required]
        [ForeignKey("IdYear")]
        public Year YearEntity { get; set; }

        ///<summary>
        /// Id of the model made this year (foreign key)
        ///</summary>
        [Required]
        public int IdModel { get; set; }

        ///<summary>
        /// Model Entity
        ///</summary>
        [Required]
        [ForeignKey("IdModel")]
        public Model ModelEntity { get; set; }
    }
}
