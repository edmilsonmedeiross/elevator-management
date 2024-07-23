namespace ElevatorManagementAPI.Domain.Models;

public class VisitsElevators
{
  public int ElevatorId { get; set; }
  public int VisitId { get; set; }
  public Elevators? Elevator { get; set; }
  public Visits? Visit { get; set; }
}
