using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Monkey.Web.Database.Payment;

public class Payment
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [ForeignKey(nameof(User))]
    public required int UserId { get; set; }
    public User.User? User { get; set; }

    public required DateOnly PaymentDate { get; set; }

    public required int Yen { get; set; }

    public required DateTime PaidAt { get; set; }
}
