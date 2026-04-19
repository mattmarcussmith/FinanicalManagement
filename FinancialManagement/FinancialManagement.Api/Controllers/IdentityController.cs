using FinancialManagement.Application.Dto.User;
using FinancialManagement.Application.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancialManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController(ICurrentUserService currentUserService) : ControllerBase
    {

        public readonly ICurrentUserService CurrentUserService = currentUserService;

        [HttpGet("get-current-user")]
        [Authorize]
        public async Task<ActionResult<GetCurrentUserResponseDto>> GetCurrentUser()
        {
         
                var response = await CurrentUserService.GetCurrentUser();
                return response;
        }
    }
}
