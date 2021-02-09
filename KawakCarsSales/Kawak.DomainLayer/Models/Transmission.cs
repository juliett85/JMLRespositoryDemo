using Kawak.DomainLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kawak.DomainLayer.Models
{
    /// <summary>
    /// Transmission entity model
    /// </summary>
    public class Transmission : Entity
    {
        ///<summary>
        ///Transmission name
        ///</summary>
        public string Name { get; set; }
    }
}
