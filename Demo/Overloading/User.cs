namespace Demo.Overloading;

public class User // model - poco class - entity  --> represent database
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public Guid SecurityStamp { get; set; }
    
}