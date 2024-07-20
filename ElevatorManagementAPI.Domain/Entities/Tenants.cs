namespace ElevatorManagementAPI.Domain.Entities;

public class Tenants
{
  public Guid Id { get; private set; }
  public string Name { get; private set; }
  public string Email { get; private set; }
  public string DocumentNumber { get; private set; }
  public bool IsSubActive { get; private set; }
  public DateTime CreatedAt { get; private set; }
  public DateTime UpdatedAt { get; private set; }
  public string CustomerId { get; private set; }
  public string? TenantColor { get; private set; }
  public string? TenantLogo { get; private set; }

  public Tenants(string name, string email, string documentNumber, bool isSubActive, string customerId, string? tenantColor, string? tenantLogo, DateTime? createdAt, DateTime? updatedAt)
  {
    Id = Guid.NewGuid();
    if (string.IsNullOrEmpty(name))
      throw new ArgumentNullException(nameof(name), "Name is required");

    if (string.IsNullOrEmpty(email))
      throw new ArgumentNullException(nameof(email), "Email is required");

    if (string.IsNullOrEmpty(documentNumber))
      throw new ArgumentNullException(nameof(documentNumber), "DocumentNumber is required");

    if (string.IsNullOrEmpty(customerId))
      throw new ArgumentNullException(nameof(customerId), "CustumerId is required");

    Name = name;
    Email = email;
    DocumentNumber = documentNumber;
    IsSubActive = isSubActive;
    CreatedAt = createdAt ?? DateTime.UtcNow;
    UpdatedAt = updatedAt ?? DateTime.UtcNow;
    CustomerId = customerId;
    TenantColor = tenantColor;
    TenantLogo = tenantLogo;
  }

  public void ChangeName(string name)
  {
    if (string.IsNullOrEmpty(name))
      throw new ArgumentNullException("Name is required");

    Name = name;
    UpdatedAt = DateTime.UtcNow;
  }

  public void ChangeEmail(string email)
  {
    if (string.IsNullOrEmpty(email))
      throw new ArgumentNullException("Email is required");

    Email = email;
    UpdatedAt = DateTime.UtcNow;
  }

  public void ChangeDocumentNumber(string documentNumber)
  {
    if (string.IsNullOrEmpty(documentNumber))
      throw new ArgumentNullException("DocumentNumber is required");

    DocumentNumber = documentNumber;
    UpdatedAt = DateTime.UtcNow;
  }

  public void ChangeIsSubActive(bool isSubActive)
  {
    IsSubActive = isSubActive;
    UpdatedAt = DateTime.UtcNow;
  }

  public void ChangeTenantColor(string tenantColor)
  {
    TenantColor = tenantColor;
    UpdatedAt = DateTime.UtcNow;
  }

  public void ChangeTenantLogo(string tenantLogo)
  {
    TenantLogo = tenantLogo;
    UpdatedAt = DateTime.UtcNow;
  }
}
