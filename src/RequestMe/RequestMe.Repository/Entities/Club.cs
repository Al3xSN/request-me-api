namespace RequestMe.Repository.Entities;

public class Club : AuditedEntity
{
    public string Name { get; set; }

    public string ImageUrl { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public IEnumerable<Party> Parties { get; set; }
}