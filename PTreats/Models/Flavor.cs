using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The flavor's type can't be empty!")]
    public string Type { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}