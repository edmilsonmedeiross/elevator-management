namespace ElevatorManagementAPI.Domain.Models;

public class VisitElevatorModel
{
  public int ElevatorId { get; set; }
  public int VisitId { get; set; }
  public ElevatorModel? Elevator { get; set; }
  public VisitModel? Visit { get; set; }
}
