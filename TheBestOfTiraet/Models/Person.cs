namespace TheBestOfTiraet.Models;

public class Person:BaseModel
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Phone { get; set; }
}