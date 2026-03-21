namespace RequestMe.Domain.Entities;

public class Party : AuditedEntity
{
    public string Name { get; set; }

    public DateTime PartyDate { get; set; }

    public bool IsActive { get; set; }

    public Guid ClubId { get; set; }
    
    public Club Club { get; set; }

    public IEnumerable<SongRequest> SongRequests { get; set; }
}