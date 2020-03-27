using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;


namespace PierresTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Categories = new HashSet<FlavorTreat>();
    }
    public int TreatId { get; set; }
    public string Description { get; set; }
    public virtual ApplicationUser User { get; set; }

    public ICollection<FlavorTreat> Flavors { get; }
  }
}