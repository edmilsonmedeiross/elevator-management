namespace ElevatorManagementAPI.Domain.Entities;

public class Users
{
  public Users(string name, DocumentType documentType, string documentNumber, string? email, string password, UserRole role, string tel, bool isActive, DateTime createdAt, DateTime updatedAt, Guid tenantId)
  {
    Id = Guid.NewGuid();
    Name = name ?? throw new ArgumentNullException(nameof(name));
    DocumentType = documentType;
    DocumentNumber = documentNumber ?? throw new ArgumentNullException(nameof(documentNumber));
    Email = email;
    SetPassword(password);
    Role = role;
    SetTel(tel);
    IsActive = isActive;
    PasswordChangedAt = null;
    InvitedBy = null;
    CreatedAt = createdAt;
    UpdatedAt = updatedAt;
    TenantId = tenantId;
  }

  public Guid Id { get; private set; }
  public string Name { get; private set; }
  public DocumentType DocumentType { get; private set; } = DocumentType.CPF;
  public string DocumentNumber { get; private set; } = null!;
  public string? Email { get; private set; }
  public string Password { get; private set; } = null!;
  public UserRole Role { get; private set; } = UserRole.Employee;
  public string Tel { get; private set; } = null!;
  public bool IsActive { get; private set; } = true;
  public DateTime? PasswordChangedAt { get; private set; }
  public Guid? InvitedBy { get; private set; }
  public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
  public DateTime UpdatedAt { get; private set; }
  public Guid TenantId { get; private set; }

  private void SetPassword(string password)
  {
    if (string.IsNullOrEmpty(password))
      throw new ArgumentNullException(nameof(password), "Password is required");
    Password = password;
  }

  private void SetTel(string tel)
  {
    if (string.IsNullOrEmpty(tel))
      throw new ArgumentNullException(nameof(tel), "Tel is required");
    Tel = tel;
  }

  public void ChangePassword(string newPassword)
  {
    SetPassword(newPassword);
    PasswordChangedAt = DateTime.UtcNow;
  }

  public void SetInvitedBy(Guid invitedById)
  {
    InvitedBy = invitedById;
  }
}

