namespace RequestMe.Repository.Entities;

public class Type : AuditedEntity
{
    public string TypeGroup { get; set; }
    
    public string TypeName { get; set; }
}