namespace RequestMe.Repository.Entities;

public class SongRequest : AuditedEntity
{
    public string Artists { get; set; }
    
    public string SongName { get; set; }

    public string Note { get; set; }

    public decimal Tip { get; set; }

    public Guid UserId { get; set; }
    
    public User User { get; set; }

    public Guid PartyId { get; set; }
    
    public Party Party { get; set; }
}