using System.ComponentModel.DataAnnotations;

namespace ElevatorManagementAPI.Domain.Requests.Tenants
{
    public class CreateTenantRequest : Request
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Documento é obrigatório")]
        public required string DocumentNumber { get; set; }
    }
}
