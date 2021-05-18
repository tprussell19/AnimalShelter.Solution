using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Type
  {
    public string Species { get; set; }
    public int Id { get; set; }
    public List<Animal> Animals { get; set; }
  }
}