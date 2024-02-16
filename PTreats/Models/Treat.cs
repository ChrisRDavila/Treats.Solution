using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The treats's description can't be empty!")]
    public string Description { get; set; }
    public List<FlavorTreat> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}