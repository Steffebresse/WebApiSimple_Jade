namespace Models;

public interface IAttraction 
{
    public Guid AttractionId { get; set; }
    public string Description { get; set; }

    public ICategory Category { get; set; }

    //Navigation properties
    public IAddress Address{ get; set; }
}