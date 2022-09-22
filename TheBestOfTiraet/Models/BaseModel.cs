namespace TheBestOfTiraet.Models;

public abstract class BaseModel:IEntity
{
    protected BaseModel()
    {
        Id = Guid.NewGuid();
        DateCreation = DateTime.UtcNow;
        DateUpdate = DateTime.UtcNow;
    }

    public Guid Id { get; }
    public DateTime DateCreation { get; }
    public DateTime DateUpdate { get; }
}