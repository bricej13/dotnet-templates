using System.ComponentModel.DataAnnotations;

namespace Webapi.Template.DB.Entities;

public class BaseEntity<T> : BaseEntity
{
    [Key] public T Id { get; set; }
}
public class BaseEntity
{
    public DateTimeOffset CreatedDate { get; set; }
    public DateTimeOffset UpdatedDate { get; set; }
}
