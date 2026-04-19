namespace FinancialManagement.Application.Dto.User
{
    public class GetCurrentUserResponseDto
    {
        public string? Name { get; set; } = string.Empty;
        public string? PreferredUsername { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? IdentityProviderId { get; set; } = string.Empty;
        public string? Role { get; set; } = string.Empty;
    }
}
