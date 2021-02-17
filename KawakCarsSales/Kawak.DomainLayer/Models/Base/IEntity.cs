namespace Kavak.DomainLayer.Entities.Base
{
    public interface IEntity<TId>
    {
       TId Id { get; } // por que solo get??
    }
}
