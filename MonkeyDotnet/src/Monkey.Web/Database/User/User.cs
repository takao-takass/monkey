using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monkey.Web.Database.User;

public class User
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public required int Id { get; set; }
    public required string Name { get; set; }
}
