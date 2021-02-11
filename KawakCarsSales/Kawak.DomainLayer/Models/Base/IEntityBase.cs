namespace Kavak.DomainLayer.Entities.Base
{
    public interface IEntityBase<TId>
    {
       TId Id { get; } // por que solo get??
    }
}
