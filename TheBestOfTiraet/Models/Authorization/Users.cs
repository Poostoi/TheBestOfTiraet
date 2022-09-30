namespace TheBestOfTiraet.Models.Authorization;

public class Users : BaseModel
{
    public string Login { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
}