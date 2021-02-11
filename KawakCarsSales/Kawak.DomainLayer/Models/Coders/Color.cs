﻿using Kavak.DomainLayer.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Models.Coders
{
    /// <summary>
    /// Color entity model
    /// </summary>
    public class Color : Entity
    {
        ///<summary>
        ///Color name
        ///</summary>
        [Required]
        public string Name { get; set; }
    }
}
