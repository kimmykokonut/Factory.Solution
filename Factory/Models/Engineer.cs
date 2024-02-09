namespace Factory.Models; 

public class Engineer
{
  public int EngineerId { get; set; }
  public string Name { get; set; }
  public string Level { get; set; }
  public string Phone { get; set; }
  public DateTime HireDate { get; set; }
  public bool IsActive { get; set; } = false
  public string Renewal { get; set; }
  public List<EngineerMachine> JoinEntities { get; }
}
