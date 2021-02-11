using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.DomainLayer.Entities.Base
{
    public abstract class Entity: IEntityBase<int>
    {
        public virtual int Id { get; protected set; } //  por que protected??? // que es virtual???
    }
}
