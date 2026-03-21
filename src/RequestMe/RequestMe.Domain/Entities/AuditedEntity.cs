namespace RequestMe.Domain.Entities;

public class AuditedEntity
{
    public Guid Id { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
    
    public string CreatedBy { get; set; }
    
    public string UpdatedBy { get; set; }

    public bool IsActive { get; set; }
}