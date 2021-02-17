using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Entities.Base
{
    public abstract class EntityBase : Entity
    {
        public virtual string Name { get; protected set; }
    }
}
