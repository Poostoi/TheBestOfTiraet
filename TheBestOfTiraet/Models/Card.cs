namespace TheBestOfTiraet.Models;

public class Card:BaseModel
{
    public Guid IdPerson { get; set; }
    public int SumCount { get; set; }
    public Guid IdDiscount { get; set; }
}