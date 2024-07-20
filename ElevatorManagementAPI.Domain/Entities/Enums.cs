namespace ElevatorManagementAPI.Domain.Entities
{
  public enum VisitType
  {
    Corrective,
    Preventive
  }

  public enum VisitStatus
  {
    Open,
    Closed
  }

  public enum ElevatorStatus
  {
    Stopped,
    Running
  }

  public enum DocumentType
  {
    RG,
    CPF
  }

  public enum UserRole
  {
    Master,
    Employee,
    Operational
  }
}
