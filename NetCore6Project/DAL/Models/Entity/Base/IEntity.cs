namespace DAL.Models.Entity.Base
{
    public interface IEntity<T>
    {
        T ID { get; set; }
    }
}
