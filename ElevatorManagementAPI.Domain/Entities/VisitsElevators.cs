namespace ElevatorManagementAPI.Domain.Entities
{
  public class VisitElevator
  {
    public VisitElevator(Guid visitId, Guid elevatorId)
    {
      VisitId = visitId;
      ElevatorId = elevatorId;
    }

    public Guid VisitId { get; private set; }
    public Visit? Visit { get; private set; }

    public Guid ElevatorId { get; private set; }
    public Elevators? Elevator { get; private set; }
  }
}
