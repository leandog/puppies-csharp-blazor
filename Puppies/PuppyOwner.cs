using System.ComponentModel.DataAnnotations;

namespace Puppies;

public class PuppyOwner
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string PayType { get; set; }

    public string Address { get; set; }
}   