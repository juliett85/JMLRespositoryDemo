using System;
using System.Collections.Generic;
using System.Text;

namespace Kawak.DomainLayer.Entities.Base
{
    public interface IEntityBorrar<TBorrar>
    {
        TBorrar Borrar { get; set; }
    }
}
