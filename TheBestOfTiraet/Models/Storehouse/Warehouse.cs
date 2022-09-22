namespace TheBestOfTiraet.Models.Storehouse;

public class Warehouse:BaseModel
{
    public string Address { get; set; }
    public Guid IdPlace { get; set; }
    public int Phone { get; set; }
    public string LinkMap { get; set; }
}