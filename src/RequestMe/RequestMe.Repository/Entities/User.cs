namespace RequestMe.Repository.Entities;

public class User : AuditedEntity
{
    public string Username { get; set; }
    
    public string Email { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string PhoneNumber { get; set; }

    public IEnumerable<SongRequest> SongRequests { get; set; }
}