namespace HP2.Domain.Common;

public abstract class SoftDeletableModel : BaseModel, ISoftDeletable
{
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
}