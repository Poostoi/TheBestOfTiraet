namespace TheBestOfTiraet.Models;

public interface IEntity
{
    Guid Id { get; }
    public DateTime DateCreation { get; }
    public DateTime DateUpdate { get; }
}